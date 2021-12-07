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
    public class GroupHobbiesController : ControllerBase
    {
        private readonly finalProjectContext _context;

        public GroupHobbiesController(finalProjectContext context)
        {
            _context = context;
        }

        // GET: api/GroupHobbies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupHobbies>>> GetGroupHobbies()
        {
            return await _context.GroupHobbies.ToListAsync();
        }

        // GET: api/GroupHobbies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroupHobbies>> GetGroupHobbies(int? id)
        {
            var groupHobbies = await _context.GroupHobbies.FindAsync(id);

            if (groupHobbies == null)
            {
                return NotFound();
            }

            return groupHobbies;
        }

        // PUT: api/GroupHobbies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroupHobbies(int id, GroupHobbies groupHobbies)
        {
            if (id != groupHobbies.Id)
            {
                return BadRequest();
            }

            _context.Entry(groupHobbies).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupHobbiesExists(id))
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

        // POST: api/GroupHobbies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GroupHobbies>> PostGroupHobbies(GroupHobbies groupHobbies)
        {
            _context.GroupHobbies.Add(groupHobbies);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GroupHobbiesExists(groupHobbies.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGroupHobbies", new { id = groupHobbies.Id }, groupHobbies);
        }

        // DELETE: api/GroupHobbies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GroupHobbies>> DeleteGroupHobbies(int id)
        {
            var groupHobbies = await _context.GroupHobbies.FindAsync(id);
            if (groupHobbies == null)
            {
                return NotFound();
            }

            _context.GroupHobbies.Remove(groupHobbies);
            await _context.SaveChangesAsync();

            return groupHobbies;
        }

        private bool GroupHobbiesExists(int id)
        {
            return _context.GroupHobbies.Any(e => e.Id == id);
        }
    }
}
