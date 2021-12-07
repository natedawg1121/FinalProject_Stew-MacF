using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject_Stew_MacF;
using System.Linq.Dynamic.Core;

namespace FinalProject_Stew_MacF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupInformationsController : ControllerBase
    {
        private readonly finalProjectContext _context;

        public GroupInformationsController(finalProjectContext context)
        {
            _context = context;
        }

        // GET: api/GroupInformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupInformation>>> GetGroupInformation()
        {
            return await _context.GroupInformation.ToListAsync();
        }

        // GET: api/GroupInformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroupInformation>> GetGroupInformation(int id)
        {
            var groupInformation = await _context.GroupInformation.FindAsync(id);

            if (groupInformation == null)
            {
                return NotFound();
            }

            return groupInformation;
        }

        // PUT: api/GroupInformations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroupInformation(int id, GroupInformation groupInformation)
        {
            if (id != groupInformation.Id)
            {
                return BadRequest();
            }

            _context.Entry(groupInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupInformationExists(id))
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

        // POST: api/GroupInformations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GroupInformation>> PostGroupInformation(GroupInformation groupInformation)
        {
            _context.GroupInformation.Add(groupInformation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GroupInformationExists(groupInformation.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGroupInformation", new { id = groupInformation.Id }, groupInformation);
        }

        // DELETE: api/GroupInformations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GroupInformation>> DeleteGroupInformation(int id)
        {
            var groupInformation = await _context.GroupInformation.FindAsync(id);
            if (groupInformation == null)
            {
                return NotFound();
            }

            _context.GroupInformation.Remove(groupInformation);
            await _context.SaveChangesAsync();

            return groupInformation;
        }

        private bool GroupInformationExists(int id)
        {
            return _context.GroupInformation.Any(e => e.Id == id);
        }
    }
}
