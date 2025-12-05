using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Agroconexion.Models;

namespace Agroconexion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ProductosController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Productos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        {
            return await _context.Productos.ToListAsync();
        }
        [HttpGet("buscar")]
        public async Task<ActionResult<IEnumerable<Producto>>> BuscarProducto([FromQuery] ProductoBusquedaParametros parametros)
        {
            var consulta = _context.Productos
                        .Include(p => p.Categoria)  // opcional, pero recomendado
                        .AsQueryable();

            if (!string.IsNullOrEmpty(parametros.buscar))
            {
                // 1️⃣ Buscar por NOMBRE
                consulta = consulta.Where(p => p.Nombre.Contains(parametros.buscar));
            }

            // Si no encontró nada, buscar por CÓDIGO
            if (!string.IsNullOrEmpty(parametros.buscar) && !consulta.Any())
            {
                consulta = _context.Productos
                            .Include(p => p.Categoria)
                            .Where(p => p.Codigo.Contains(parametros.buscar));
            }

            return await consulta.ToListAsync();
        }



        // GET: api/Productos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
                return NotFound();

            return producto;
        }

        // PUT: api/Productos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, Producto producto)
        {
            if (id != producto.idProducto)
                return BadRequest();

            _context.Entry(producto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // POST: api/Productos
        [HttpPost]
        public async Task<ActionResult<Producto>> PostProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProducto), new { id = producto.idProducto }, producto);
        }

        // DELETE: api/Productos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
                return NotFound();

            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.idProducto == id);
        }
    }
}
