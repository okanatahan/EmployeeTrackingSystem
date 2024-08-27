using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YoneticilerController : ControllerBase
    {
        private readonly ApiContext _context;

        public YoneticilerController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Yonetici
        [HttpGet]
        public async Task<ActionResult<IEnumerable<YoneticiModel>>> GetYoneticiModel()
        {
            return await _context.Yoneticiler.ToListAsync();
        }

        // GET: api/Yonetici/5
        [HttpGet("{id}")]
        public async Task<ActionResult<YoneticiModel>> GetYoneticiModel(int id)
        {
            var yoneticiModel = await _context.Yoneticiler.FindAsync(id);

            if (yoneticiModel == null)
            {
                return NotFound();
            }

            return yoneticiModel;
        }

        // PUT: api/Yonetici/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutYoneticiModel(int id, YoneticiModel yoneticiModel)
        {
            if (id != yoneticiModel.YoneticiID)
            {
                return BadRequest();
            }

            _context.Entry(yoneticiModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YoneticiModelExists(id))
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

        // POST: api/Yonetici
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<YoneticiModel>> PostYoneticiModel(YoneticiModel yoneticiModel)
        {
            _context.Yoneticiler.Add(yoneticiModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetYoneticiModel", new { id = yoneticiModel.YoneticiID }, yoneticiModel);
        }

        // DELETE: api/Yonetici/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteYoneticiModel(int id)
        {
            var yoneticiModel = await _context.Yoneticiler.FindAsync(id);
            if (yoneticiModel == null)
            {
                return NotFound();
            }

            _context.Yoneticiler.Remove(yoneticiModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool YoneticiModelExists(int id)
        {
            return _context.Yoneticiler.Any(e => e.YoneticiID == id);
        }
    }
}
