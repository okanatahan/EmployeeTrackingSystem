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
    public class LokasyonlarController : ControllerBase
    {
        private readonly ApiContext _context;

        public LokasyonlarController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Lokasyonlar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LokasyonModel>>> GetLokasyonModel()
        {
            return await _context.Lokasyonlar.ToListAsync();
        }

        // GET: api/Lokasyonlar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LokasyonModel>> GetLokasyonModel(int id)
        {
            var lokasyonModel = await _context.Lokasyonlar.FindAsync(id);

            if (lokasyonModel == null)
            {
                return NotFound();
            }

            return lokasyonModel;
        }

        // PUT: api/Lokasyonlar/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLokasyonModel(int id, LokasyonModel lokasyonModel)
        {
            if (id != lokasyonModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(lokasyonModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LokasyonModelExists(id))
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

        // POST: api/Lokasyonlar
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LokasyonModel>> PostLokasyonModel(LokasyonModel lokasyonModel)
        {
            _context.Lokasyonlar.Add(lokasyonModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLokasyonModel", new { id = lokasyonModel.ID }, lokasyonModel);
        }

        // DELETE: api/Lokasyonlar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLokasyonModel(int id)
        {
            var lokasyonModel = await _context.Lokasyonlar.FindAsync(id);
            if (lokasyonModel == null)
            {
                return NotFound();
            }

            _context.Lokasyonlar.Remove(lokasyonModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LokasyonModelExists(int id)
        {
            return _context.Lokasyonlar.Any(e => e.ID == id);
        }
    }
}
