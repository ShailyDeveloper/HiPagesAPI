using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tradiesJobs.Models;

namespace tradiesJobs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustsController : ControllerBase
    {
        private readonly MVCContext _context;

        public CustsController(MVCContext context)
        {
            _context = context;
        }

        // GET: api/Custs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cust>>> GetCust(string status)
        {
            var custs = _context.Cust.AsQueryable();
            if (status != null) // Adds the condition to check availability 
            {
                custs = _context.Cust.Where(i => i.Status==status);
            }
            return await custs.ToListAsync();
        }

        // GET: api/Custs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cust>> GetCust(int id)
        {
            var cust = await _context.Cust.FindAsync(id);

            if (cust == null)
            {
                return NotFound();
            }

            return cust;
        }

        // PUT: api/Custs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCust(int id, Cust cust)
        {
            if (id != cust.Id)
            {
                return BadRequest();
            }

            _context.Entry(cust).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustExists(id))
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

        // POST: api/Custs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Cust>> PostCust(Cust cust)
        {
            _context.Cust.Add(cust);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CustExists(cust.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCust", new { id = cust.Id }, cust);
        }

        // DELETE: api/Custs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cust>> DeleteCust(int id)
        {
            var cust = await _context.Cust.FindAsync(id);
            if (cust == null)
            {
                return NotFound();
            }

            _context.Cust.Remove(cust);
            await _context.SaveChangesAsync();

            return cust;
        }

        private bool CustExists(int id)
        {
            return _context.Cust.Any(e => e.Id == id);
        }
    }
}
