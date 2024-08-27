using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmanlarController : ControllerBase
    {
        private readonly ApiContext _context;

        public DepartmanlarController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Departman
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmanModel>>> GetDepartmanModel()
        {
            return await _context.Departmanlar.ToListAsync();
        }

        // GET: api/Departman/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmanModel>> GetDepartmanModel(int id)
        {
            var departmanModel = await _context.Departmanlar.FindAsync(id);

            if (departmanModel == null)
            {
                return NotFound();
            }

            return departmanModel;
        }

        // PUT: api/Departman/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartmanModel(int id, DepartmanModel departmanModel)
        {
            if (id != departmanModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(departmanModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmanModelExists(id))
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

        // POST: api/Departman
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DepartmanModel>> PostDepartmanModel(DepartmanModel departmanModel)
        {
            _context.Departmanlar.Add(departmanModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartmanModel", new { id = departmanModel.ID }, departmanModel);
        }

        // DELETE: api/Departman/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartmanModel(int id)
        {
            var departmanModel = await _context.Departmanlar.FindAsync(id);
            if (departmanModel == null)
            {
                return NotFound();
            }

            _context.Departmanlar.Remove(departmanModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepartmanModelExists(int id)
        {
            return _context.Departmanlar.Any(e => e.ID == id);
        }
    }
}
