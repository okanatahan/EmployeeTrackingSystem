using Api.Data;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : Controller
    {
        private readonly ApiContext _context;
        public PersonelController(ApiContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PersonelModel>> GetPersoneller()
        {
            return _context.Personel.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<PersonelModel> GetPersonel(int id)
        {
            var customer = _context.Personel.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return customer;
        }

        [HttpPost]
        public ActionResult<PersonelModel> CreatePersonel(PersonelModel personel)
        {
            if (personel == null)
            {
                return BadRequest();
            }

            _context.Personel.Add(personel);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetPersonel), new { id = personel.PersonelID }, personel);
        }
    }
}
