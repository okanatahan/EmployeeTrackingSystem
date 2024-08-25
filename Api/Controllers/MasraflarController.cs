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
    public class MasraflarController : ControllerBase
    {
        private readonly ApiContext _context;

        public MasraflarController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Masraflar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MasrafModel>>> GetMasrafModel()
        {
            return await _context.Masraflar.ToListAsync();
        }

        // GET: api/Masraflar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MasrafModel>> GetMasrafModel(int id)
        {
            var masrafModel = await _context.Masraflar.FindAsync(id);

            if (masrafModel == null)
            {
                return NotFound();
            }

            return masrafModel;
        }

        // PUT: api/Masraflar/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMasrafModel(int id, MasrafModel masrafModel)
        {
            if (id != masrafModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(masrafModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MasrafModelExists(id))
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

        // POST: api/Masraflar
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MasrafModel>> PostMasrafModel(MasrafModel masrafModel)
        {
            _context.Masraflar.Add(masrafModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMasrafModel", new { id = masrafModel.ID }, masrafModel);
        }

        // DELETE: api/Masraflar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMasrafModel(int id)
        {
            var masrafModel = await _context.Masraflar.FindAsync(id);
            if (masrafModel == null)
            {
                return NotFound();
            }

            _context.Masraflar.Remove(masrafModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MasrafModelExists(int id)
        {
            return _context.Masraflar.Any(e => e.ID == id);
        }
    }
}
