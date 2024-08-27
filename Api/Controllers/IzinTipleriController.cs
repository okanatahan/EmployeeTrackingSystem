using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IzinTipleriController : ControllerBase
    {
        private readonly ApiContext _context;

        public IzinTipleriController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/IzinTipleri
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IzinTipModel>>> GetIzinTipleriModel()
        {
            return await _context.IzinTipleri.ToListAsync();
        }

        // GET: api/IzinTipleri/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IzinTipModel>> GetIzinTipleriModel(int id)
        {
            var izinTipleriModel = await _context.IzinTipleri.FindAsync(id);

            if (izinTipleriModel == null)
            {
                return NotFound();
            }

            return izinTipleriModel;
        }

        // PUT: api/IzinTipleri/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIzinTipleriModel(int id, IzinTipModel izinTipleriModel)
        {
            if (id != izinTipleriModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(izinTipleriModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IzinTipleriModelExists(id))
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

        // POST: api/IzinTipleri
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IzinTipModel>> PostIzinTipleriModel(IzinTipModel izinTipleriModel)
        {
            _context.IzinTipleri.Add(izinTipleriModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIzinTipleriModel", new { id = izinTipleriModel.ID }, izinTipleriModel);
        }

        // DELETE: api/IzinTipleri/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIzinTipleriModel(int id)
        {
            var izinTipleriModel = await _context.IzinTipleri.FindAsync(id);
            if (izinTipleriModel == null)
            {
                return NotFound();
            }

            _context.IzinTipleri.Remove(izinTipleriModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IzinTipleriModelExists(int id)
        {
            return _context.IzinTipleri.Any(e => e.ID == id);
        }
    }
}
