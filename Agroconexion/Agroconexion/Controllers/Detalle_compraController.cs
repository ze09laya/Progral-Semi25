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
    public class Detalle_compraController : ControllerBase
    {
        private readonly MyDbContext _context;

        public Detalle_compraController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Detalle_compra
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Detalle_compra>>> GetDetalle_Compra()
        {
            return await _context.Detalle_Compra.ToListAsync();
        }

        // GET: api/Detalle_compra/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Detalle_compra>> GetDetalle_compra(int id)
        {
            var detalle_compra = await _context.Detalle_Compra.FindAsync(id);

            if (detalle_compra == null)
            {
                return NotFound();
            }

            return detalle_compra;
        }

        // PUT: api/Detalle_compra/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalle_compra(int id, Detalle_compra detalle_compra)
        {
            if (id != detalle_compra.IdDetalle_Compra)
            {
                return BadRequest();
            }

            _context.Entry(detalle_compra).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Detalle_compraExists(id))
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

        // POST: api/Detalle_compra
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Detalle_compra>> PostDetalle_compra(Detalle_compra detalle_compra)
        {
            _context.Detalle_Compra.Add(detalle_compra);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalle_compra", new { id = detalle_compra.IdDetalle_Compra }, detalle_compra);
        }

        // DELETE: api/Detalle_compra/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalle_compra(int id)
        {
            var detalle_compra = await _context.Detalle_Compra.FindAsync(id);
            if (detalle_compra == null)
            {
                return NotFound();
            }

            _context.Detalle_Compra.Remove(detalle_compra);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Detalle_compraExists(int id)
        {
            return _context.Detalle_Compra.Any(e => e.IdDetalle_Compra == id);
        }
    }
}
