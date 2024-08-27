using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaseronlarController : ControllerBase
    {
        private readonly ApiContext _context;

        public TaseronlarController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Taseronlar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaseronModel>>> GetTaseronModel()
        {
            return await _context.Taseronlar.ToListAsync();
        }

        // GET: api/Taseronlar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaseronModel>> GetTaseronModel(int id)
        {
            var taseronModel = await _context.Taseronlar.FindAsync(id);

            if (taseronModel == null)
            {
                return NotFound();
            }

            return taseronModel;
        }

        // PUT: api/Taseronlar/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaseronModel(int id, TaseronModel taseronModel)
        {
            if (id != taseronModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(taseronModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaseronModelExists(id))
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

        // POST: api/Taseronlar
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TaseronModel>> PostTaseronModel(TaseronModel taseronModel)
        {
            _context.Taseronlar.Add(taseronModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaseronModel", new { id = taseronModel.ID }, taseronModel);
        }

        // DELETE: api/Taseronlar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaseronModel(int id)
        {
            var taseronModel = await _context.Taseronlar.FindAsync(id);
            if (taseronModel == null)
            {
                return NotFound();
            }

            _context.Taseronlar.Remove(taseronModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaseronModelExists(int id)
        {
            return _context.Taseronlar.Any(e => e.ID == id);
        }
    }
}
