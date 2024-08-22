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
    public class PersonellerController : ControllerBase
    {
        private readonly ApiContext _context;

        public PersonellerController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Personeller
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonelModel>>> GetPersonelModel()
        {
            return await _context.Personeller.ToListAsync();
        }

        // GET: api/Personeller/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonelModel>> GetPersonelModel(int id)
        {
            var personelModel = await _context.Personeller.FindAsync(id);

            if (personelModel == null)
            {
                return NotFound();
            }

            return personelModel;
        }

        // PUT: api/Personeller/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonelModel(int id, PersonelModel personelModel)
        {
            if (id != personelModel.PersonelID)
            {
                return BadRequest();
            }

            _context.Entry(personelModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonelModelExists(id))
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

        // POST: api/Personeller
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonelModel>> PostPersonelModel(PersonelModel personelModel)
        {
            _context.Personeller.Add(personelModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonelModel", new { id = personelModel.PersonelID }, personelModel);
        }

        // DELETE: api/Personeller/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonelModel(int id)
        {
            var personelModel = await _context.Personeller.FindAsync(id);
            if (personelModel == null)
            {
                return NotFound();
            }

            _context.Personeller.Remove(personelModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonelModelExists(int id)
        {
            return _context.Personeller.Any(e => e.PersonelID == id);
        }
    }
}
