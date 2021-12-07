using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject_Stew_MacF;

namespace FinalProject_Stew_MacF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupSchoolsController : ControllerBase
    {
        private readonly finalProjectContext _context;

        public GroupSchoolsController(finalProjectContext context)
        {
            _context = context;
        }

        // GET: api/GroupSchools
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupSchools>>> GetGroupSchools()
        {
            return await _context.GroupSchools.ToListAsync();
        }

        // GET: api/GroupSchools/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroupSchools>> GetGroupSchools(int? id)
        {
            var groupSchools = await _context.GroupSchools.FindAsync(id);

            if (groupSchools == null)
            {
                return NotFound();
            }

            return groupSchools;
        }

        // PUT: api/GroupSchools/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroupSchools(int id, GroupSchools groupSchools)
        {
            if (id != groupSchools.Id)
            {
                return BadRequest();
            }

            _context.Entry(groupSchools).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupSchoolsExists(id))
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

        // POST: api/GroupSchools
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GroupSchools>> PostGroupSchools(GroupSchools groupSchools)
        {
            _context.GroupSchools.Add(groupSchools);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GroupSchoolsExists(groupSchools.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGroupSchools", new { id = groupSchools.Id }, groupSchools);
        }

        // DELETE: api/GroupSchools/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GroupSchools>> DeleteGroupSchools(int id)
        {
            var groupSchools = await _context.GroupSchools.FindAsync(id);
            if (groupSchools == null)
            {
                return NotFound();
            }

            _context.GroupSchools.Remove(groupSchools);
            await _context.SaveChangesAsync();

            return groupSchools;
        }

        private bool GroupSchoolsExists(int id)
        {
            return _context.GroupSchools.Any(e => e.Id == id);
        }
    }
}
