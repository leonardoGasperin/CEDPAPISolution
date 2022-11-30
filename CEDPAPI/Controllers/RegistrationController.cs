using CEDPAPI.Context;
using CEDPAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CEDPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly CEdpApiContext _context;

        public RegistrationController(CEdpApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.Registrations);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var gradeFilter = _context.Registrations.Where(w => w.Id == id).FirstOrDefault()!;
            return Ok(gradeFilter);
        }

        [HttpPost]
        public ActionResult Post(RegistrationEntity registration)
        {
            _context.Registrations.Add(registration);
            _context.SaveChanges();
            return Ok(registration);
        }

        [HttpPut("{id}")]
        public ActionResult Put(RegistrationEntity registration)
        {
            _context.Registrations.Update(registration);
            _context.SaveChanges();
            return Ok(registration);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (_context.Registrations.Any(w => w.Id == id))
            {
                var registrationRemove = _context.Registrations.Where(w => w.Id == id).FirstOrDefault()!;

                _context.Registrations.Remove(registrationRemove);
                _context.SaveChanges();
            }
        }
    }
}
