using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vetapi.DAL;
using vetapi.Models;

namespace vetapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesparacitacionesController : ControllerBase
    {
        private readonly VetContext _context;

        public DesparacitacionesController(VetContext context)
        {
            _context = context;
        }

        // GET: api/Desparacitaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Desparacitacion>>> GetDesparacitaciones()
        {
            return await _context.Desparacitaciones.ToListAsync();
        }

        // GET: api/Desparacitaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Desparacitacion>> GetDesparacitacion(int id)
        {
            var desparacitacion = await _context.Desparacitaciones.FindAsync(id);

            if (desparacitacion == null)
            {
                return NotFound();
            }

            return desparacitacion;
        }

        // PUT: api/Desparacitaciones/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDesparacitacion(int id, Desparacitacion desparacitacion)
        {
            if (id != desparacitacion.Id)
            {
                return BadRequest();
            }

            _context.Entry(desparacitacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DesparacitacionExists(id))
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

        // POST: api/Desparacitaciones
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Desparacitacion>> PostDesparacitacion(Desparacitacion desparacitacion)
        {
            _context.Desparacitaciones.Add(desparacitacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDesparacitacion", new { id = desparacitacion.Id }, desparacitacion);
        }

        // DELETE: api/Desparacitaciones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Desparacitacion>> DeleteDesparacitacion(int id)
        {
            var desparacitacion = await _context.Desparacitaciones.FindAsync(id);
            if (desparacitacion == null)
            {
                return NotFound();
            }

            _context.Desparacitaciones.Remove(desparacitacion);
            await _context.SaveChangesAsync();

            return desparacitacion;
        }

        private bool DesparacitacionExists(int id)
        {
            return _context.Desparacitaciones.Any(e => e.Id == id);
        }
    }
}
