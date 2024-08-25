using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IsletmelerController : ControllerBase
    {
        private readonly ApiContext _context;

        public IsletmelerController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Isletmeler
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IsletmeModel>>> GetIsletmeModel()
        {
            return await _context.Isletmeler.ToListAsync();
        }

        // GET: api/Isletmeler/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IsletmeModel>> GetIsletmeModel(int id)
        {
            var isletmeModel = await _context.Isletmeler.FindAsync(id);

            if (isletmeModel == null)
            {
                return NotFound();
            }

            return isletmeModel;
        }

        // PUT: api/Isletmeler/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIsletmeModel(int id, IsletmeModel isletmeModel)
        {
            if (id != isletmeModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(isletmeModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IsletmeModelExists(id))
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

        // POST: api/Isletmeler
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IsletmeModel>> PostIsletmeModel(IsletmeModel isletmeModel)
        {
            _context.Isletmeler.Add(isletmeModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIsletmeModel", new { id = isletmeModel.ID }, isletmeModel);
        }

        // DELETE: api/Isletmeler/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIsletmeModel(int id)
        {
            var isletmeModel = await _context.Isletmeler.FindAsync(id);
            if (isletmeModel == null)
            {
                return NotFound();
            }

            _context.Isletmeler.Remove(isletmeModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IsletmeModelExists(int id)
        {
            return _context.Isletmeler.Any(e => e.ID == id);
        }
    }
}
