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
    public class IzinTalepleriController : ControllerBase
    {
        private readonly ApiContext _context;

        public IzinTalepleriController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/IzinTalepleri
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IzinTalepModel>>> GetIzinTalepleriModel()
        {
            return await _context.IzinTalepleri.ToListAsync();
        }

        // PUT: api/IzinTalepleri/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIzinTalepleriModel(int id, IzinTalepModel izinTalepleriModel)
        {
            if (id != izinTalepleriModel.FK_PersonelID)
            {
                return BadRequest();
            }

            _context.Entry(izinTalepleriModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IzinTalepleriModelExists(id))
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

        // POST: api/IzinTalepleri
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IzinTalepModel>> PostIzinTalepleriModel(IzinTalepModel izinTalepleriModel)
        {
            _context.IzinTalepleri.Add(izinTalepleriModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIzinTalepleriModel", new { id = izinTalepleriModel.FK_PersonelID }, izinTalepleriModel);
        }

        // DELETE: api/IzinTalepleri/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIzinTalepleriModel(int id)
        {
            var izinTalepleriModel = await _context.IzinTalepleri.FindAsync(id);
            if (izinTalepleriModel == null)
            {
                return NotFound();
            }

            _context.IzinTalepleri.Remove(izinTalepleriModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IzinTalepleriModelExists(int id)
        {
            return _context.IzinTalepleri.Any(e => e.FK_PersonelID == id);
        }
    }
}
