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
    public class Detalle_ventaController : ControllerBase
    {
        private readonly MyDbContext _context;

        public Detalle_ventaController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Detalle_venta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Detalle_venta>>> GetDetalle_Venta()
        {
            return await _context.Detalle_Venta.ToListAsync();
        }

        // GET: api/Detalle_venta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Detalle_venta>> GetDetalle_venta(int id)
        {
            var detalle_venta = await _context.Detalle_Venta.FindAsync(id);

            if (detalle_venta == null)
            {
                return NotFound();
            }

            return detalle_venta;
        }

        // PUT: api/Detalle_venta/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalle_venta(int id, Detalle_venta detalle_venta)
        {
            if (id != detalle_venta.IdDetalle_Venta)
            {
                return BadRequest();
            }

            _context.Entry(detalle_venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Detalle_ventaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Detalle_venta
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Detalle_venta>> PostDetalle_venta(Detalle_venta detalle_venta)
        {
            _context.Detalle_Venta.Add(detalle_venta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalle_venta", new { id = detalle_venta.IdDetalle_Venta }, detalle_venta);
        }

        // DELETE: api/Detalle_venta/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalle_venta(int id)
        {
            var detalle_venta = await _context.Detalle_Venta.FindAsync(id);
            if (detalle_venta == null)
            {
                return NotFound();
            }

            _context.Detalle_Venta.Remove(detalle_venta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Detalle_ventaExists(int id)
        {
            return _context.Detalle_Venta.Any(e => e.IdDetalle_Venta == id);
        }
    }
}
