using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendikalarController : ControllerBase
    {
        private readonly ApiContext _context;

        public SendikalarController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Sendikalar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SendikaModel>>> GetSendikaModel()
        {
            return await _context.Sendikalar.ToListAsync();
        }

        // GET: api/Sendikalar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SendikaModel>> GetSendikaModel(int id)
        {
            var sendikaModel = await _context.Sendikalar.FindAsync(id);

            if (sendikaModel == null)
            {
                return NotFound();
            }

            return sendikaModel;
        }

        // PUT: api/Sendikalar/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSendikaModel(int id, SendikaModel sendikaModel)
        {
            if (id != sendikaModel.ID)
            {
                return BadRequest();
            }

            _context.Entry(sendikaModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SendikaModelExists(id))
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

        // POST: api/Sendikalar
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SendikaModel>> PostSendikaModel(SendikaModel sendikaModel)
        {
            _context.Sendikalar.Add(sendikaModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSendikaModel", new { id = sendikaModel.ID }, sendikaModel);
        }

        // DELETE: api/Sendikalar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSendikaModel(int id)
        {
            var sendikaModel = await _context.Sendikalar.FindAsync(id);
            if (sendikaModel == null)
            {
                return NotFound();
            }

            _context.Sendikalar.Remove(sendikaModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SendikaModelExists(int id)
        {
            return _context.Sendikalar.Any(e => e.ID == id);
        }
    }
}
