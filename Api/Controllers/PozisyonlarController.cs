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
    public class PozisyonlarController : ControllerBase
    {
        private readonly ApiContext _context;

        public PozisyonlarController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Pozisyonlar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PozisyonModel>>> GetPozisyonModel()
        {
            return await _context.Pozisyonlar.ToListAsync();
        }

        // GET: api/Pozisyonlar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PozisyonModel>> GetPozisyonModel(int id)
        {
            var pozisyonModel = await _context.Pozisyonlar.FindAsync(id);

            if (pozisyonModel == null)
            {
                return NotFound();
            }

            return pozisyonModel;
        }

        // PUT: api/Pozisyonlar/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPozisyonModel(int id, PozisyonModel pozisyonModel)
        {
            if (id != pozisyonModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(pozisyonModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PozisyonModelExists(id))
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

        // POST: api/Pozisyonlar
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PozisyonModel>> PostPozisyonModel(PozisyonModel pozisyonModel)
        {
            _context.Pozisyonlar.Add(pozisyonModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPozisyonModel", new { id = pozisyonModel.ID }, pozisyonModel);
        }

        // DELETE: api/Pozisyonlar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePozisyonModel(int id)
        {
            var pozisyonModel = await _context.Pozisyonlar.FindAsync(id);
            if (pozisyonModel == null)
            {
                return NotFound();
            }

            _context.Pozisyonlar.Remove(pozisyonModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PozisyonModelExists(int id)
        {
            return _context.Pozisyonlar.Any(e => e.ID == id);
        }
    }
}
