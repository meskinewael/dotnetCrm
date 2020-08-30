using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using crm;
using crm.Model;

namespace crm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustemersController : ControllerBase
    {
        private readonly CrmDbcontext _context;

        public CustemersController(CrmDbcontext context)
        {
            _context = context;
        }

        // GET: api/Custemers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Custemer>>> GetCustemers()
        {
            return await _context.Custemers.ToListAsync();
        }

        // GET: api/Custemers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Custemer>> GetCustemer(long id)
        {
            var custemer = await _context.Custemers.FindAsync(id);

            if (custemer == null)
            {
                return NotFound();
            }

            return custemer;
        }

        // PUT: api/Custemers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustemer(long id, Custemer custemer)
        {
            if (id != custemer.id)
            {
                return BadRequest();
            }

            _context.Entry(custemer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustemerExists(id))
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

        // POST: api/Custemers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Custemer>> PostCustemer(Custemer custemer)
        {
            _context.Custemers.Add(custemer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustemer", new { id = custemer.id }, custemer);
        }

        // DELETE: api/Custemers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Custemer>> DeleteCustemer(long id)
        {
            var custemer = await _context.Custemers.FindAsync(id);
            if (custemer == null)
            {
                return NotFound();
            }

            _context.Custemers.Remove(custemer);
            await _context.SaveChangesAsync();

            return custemer;
        }

        private bool CustemerExists(long id)
        {
            return _context.Custemers.Any(e => e.id == id);
        }
    }
}
