using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AltDepartmanlarController : ControllerBase
    {
        private readonly ApiContext _context;

        public AltDepartmanlarController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/AltDepartmanlar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AltDepartmanModel>>> GetAltDepartmanModel()
        {
            return await _context.AltDepartmanlar.ToListAsync();
        }

        // GET: api/AltDepartmanlar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AltDepartmanModel>> GetAltDepartmanModel(int id)
        {
            var altDepartmanModel = await _context.AltDepartmanlar.FindAsync(id);

            if (altDepartmanModel == null)
            {
                return NotFound();
            }

            return altDepartmanModel;
        }

        // PUT: api/AltDepartmanlar/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAltDepartmanModel(int id, AltDepartmanModel altDepartmanModel)
        {
            if (id != altDepartmanModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(altDepartmanModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AltDepartmanModelExists(id))
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

        // POST: api/AltDepartmanlar
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AltDepartmanModel>> PostAltDepartmanModel(AltDepartmanModel altDepartmanModel)
        {
            _context.AltDepartmanlar.Add(altDepartmanModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAltDepartmanModel", new { id = altDepartmanModel.ID }, altDepartmanModel);
        }

        // DELETE: api/AltDepartmanlar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAltDepartmanModel(int id)
        {
            var altDepartmanModel = await _context.AltDepartmanlar.FindAsync(id);
            if (altDepartmanModel == null)
            {
                return NotFound();
            }

            _context.AltDepartmanlar.Remove(altDepartmanModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AltDepartmanModelExists(int id)
        {
            return _context.AltDepartmanlar.Any(e => e.ID == id);
        }
    }
}
