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
    public class GroupFoodsController : ControllerBase
    {
        private readonly finalProjectContext _context;

        public GroupFoodsController(finalProjectContext context)
        {
            _context = context;
        }

        // GET: api/GroupFoods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupFoods>>> GetGroupFoods()
        {
            return await _context.GroupFoods.ToListAsync();
        }

        // GET: api/GroupFoods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroupFoods>> GetGroupFoods(int id)
        {
            var groupFoods = await _context.GroupFoods.FindAsync(id);

            if (groupFoods == null)
            {
                return NotFound();
            }

            return groupFoods;
        }

        // PUT: api/GroupFoods/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroupFoods(int id, GroupFoods groupFoods)
        {
            if (id != groupFoods.Id)
            {
                return BadRequest();
            }

            _context.Entry(groupFoods).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupFoodsExists(id))
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

        // POST: api/GroupFoods
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GroupFoods>> PostGroupFoods(GroupFoods groupFoods)
        {
            _context.GroupFoods.Add(groupFoods);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GroupFoodsExists(groupFoods.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGroupFoods", new { id = groupFoods.Id }, groupFoods);
        }

        // DELETE: api/GroupFoods/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GroupFoods>> DeleteGroupFoods(int id)
        {
            var groupFoods = await _context.GroupFoods.FindAsync(id);
            if (groupFoods == null)
            {
                return NotFound();
            }

            _context.GroupFoods.Remove(groupFoods);
            await _context.SaveChangesAsync();

            return groupFoods;
        }

        private bool GroupFoodsExists(int id)
        {
            return _context.GroupFoods.Any(e => e.Id == id);
        }
    }
}
