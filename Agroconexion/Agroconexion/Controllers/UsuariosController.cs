using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Agroconexion.Models;

namespace Agroconexion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly MyDbContext _context;

        public UsuariosController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await _context.Usuario.ToListAsync();
        }
        [HttpGet("buscar")]
        public async Task<ActionResult<IEnumerable<Usuario>>> BuscarUsuario([FromQuery] UsuarioBusquedaParametros parametros)
        {
            var consulta = _context.Usuario.AsQueryable();
            if (!string.IsNullOrEmpty(parametros.buscar))
            {
                consulta = consulta.Where(Usuario => Usuario.Nombre_Completo.Contains(parametros.buscar));
            }
            if (!string.IsNullOrEmpty(parametros.buscar) && consulta.Count() <= 0)
            {
                consulta = _context.Usuario.AsQueryable();
                consulta = consulta.Where(Usuario => Usuario.Documento.Contains(parametros.buscar));
            }
            return await consulta.ToListAsync();
        }
        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);

            if (usuario == null)
                return NotFound();

            return usuario;
        }

        // PUT: api/Usuarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.idUsuario)
                return BadRequest();

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // POST: api/Usuarios
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id = usuario.idUsuario }, usuario);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
                return NotFound();

            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Usuarios/login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.Correo) || string.IsNullOrEmpty(request.Clave))
                return BadRequest(new { message = "Correo y clave son requeridos" });

            var usuario = await _context.Usuario
                .Include(u => u.Rol) // 🔹 Incluye la relación con la tabla Rol
                .FirstOrDefaultAsync(u => u.Correo == request.Correo && u.Clave == request.Clave);

            if (usuario == null)
                return Unauthorized(new { message = "Usuario o contraseña incorrectos" });

            return Ok(new
            {
                idUsuario = usuario.idUsuario,
                nombre = usuario.Nombre_Completo,
                correo = usuario.Correo,
                descripcionRol = usuario.Rol.Descripcion // 🔹 Este campo lo necesitamos en el login
            });
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.idUsuario == id);
        }
    }


// Clase para login
public class LoginRequest
    {
        public string Correo { get; set; }
        public string Clave { get; set; }
}
}
