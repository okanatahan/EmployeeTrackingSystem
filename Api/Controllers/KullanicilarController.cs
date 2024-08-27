using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Data;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullanicilarController : ControllerBase
    {
        private readonly ApiContext _context;

        public KullanicilarController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Kullanicilar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KullaniciModel>>> GetKullaniciModel()
        {
            return await _context.Kullanicilar.ToListAsync();
        }

        // GET: api/Kullanicilar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KullaniciModel>> GetKullaniciModel(int id)
        {
            var kullaniciModel = await _context.Kullanicilar.FindAsync(id);

            if (kullaniciModel == null)
            {
                return NotFound();
            }

            return kullaniciModel;
        }

        // PUT: api/Kullanicilar/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKullaniciModel(int id, KullaniciModel kullaniciModel)
        {
            if (id != kullaniciModel.FK_PersonelID)
            {
                return BadRequest();
            }

            _context.Entry(kullaniciModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KullaniciModelExists(id))
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

        // POST: api/Kullanicilar
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<KullaniciModel>> PostKullaniciModel(KullaniciModel kullaniciModel)
        {
            _context.Kullanicilar.Add(kullaniciModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKullaniciModel", new { id = kullaniciModel.FK_PersonelID }, kullaniciModel);
        }

        // DELETE: api/Kullanicilar/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKullaniciModel(int id)
        {
            var kullaniciModel = await _context.Kullanicilar.FindAsync(id);
            if (kullaniciModel == null)
            {
                return NotFound();
            }

            _context.Kullanicilar.Remove(kullaniciModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KullaniciModelExists(int id)
        {
            return _context.Kullanicilar.Any(e => e.FK_PersonelID == id);
        }
    }
}
