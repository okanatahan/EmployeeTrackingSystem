using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GecislerController : ControllerBase
    {
        private readonly ApiContext _context;

        public GecislerController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Gecisler
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GecisModel>>> GetGecisModel()
        {
            return await _context.Gecisler.ToListAsync();
        }

        // GET: api/Gecisler/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GecisModel>> GetGecisModel(int id)
        {
            var gecisModel = await _context.Gecisler.FindAsync(id);

            if (gecisModel == null)
            {
                return NotFound();
            }

            return gecisModel;
        }

        // PUT: api/Gecisler/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGecisModel(int id, GecisModel gecisModel)
        {
            if (id != gecisModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(gecisModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GecisModelExists(id))
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

        // POST: api/Gecisler
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GecisModel>> PostGecisModel(GecisModel gecisModel)
        {
            _context.Gecisler.Add(gecisModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGecisModel", new { id = gecisModel.ID }, gecisModel);
        }

        // DELETE: api/Gecisler/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGecisModel(int id)
        {
            var gecisModel = await _context.Gecisler.FindAsync(id);
            if (gecisModel == null)
            {
                return NotFound();
            }

            _context.Gecisler.Remove(gecisModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GecisModelExists(int id)
        {
            return _context.Gecisler.Any(e => e.ID == id);
        }
    }
}
