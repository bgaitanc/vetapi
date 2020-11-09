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
    public class CirugiasController : ControllerBase
    {
        private readonly VetContext _context;

        public CirugiasController(VetContext context)
        {
            _context = context;
        }

        // GET: api/Cirugias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cirugia>>> GetCirugias()
        {
            return await _context.Cirugias.ToListAsync();
        }

        // GET: api/Cirugias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cirugia>> GetCirugia(int id)
        {
            var cirugia = await _context.Cirugias.FindAsync(id);

            if (cirugia == null)
            {
                return NotFound();
            }

            return cirugia;
        }

        // PUT: api/Cirugias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCirugia(int id, Cirugia cirugia)
        {
            if (id != cirugia.Id)
            {
                return BadRequest();
            }

            _context.Entry(cirugia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CirugiaExists(id))
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

        // POST: api/Cirugias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cirugia>> PostCirugia(Cirugia cirugia)
        {
            _context.Cirugias.Add(cirugia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCirugia", new { id = cirugia.Id }, cirugia);
        }

        // DELETE: api/Cirugias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cirugia>> DeleteCirugia(int id)
        {
            var cirugia = await _context.Cirugias.FindAsync(id);
            if (cirugia == null)
            {
                return NotFound();
            }

            _context.Cirugias.Remove(cirugia);
            await _context.SaveChangesAsync();

            return cirugia;
        }

        private bool CirugiaExists(int id)
        {
            return _context.Cirugias.Any(e => e.Id == id);
        }
    }
}
