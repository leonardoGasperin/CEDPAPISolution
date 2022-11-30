using CEDPAPI.Context;
using CEDPAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CEDPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly CEdpApiContext _context;

        public InstructorController(CEdpApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.Instructors);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var instructorFilter = _context.Instructors.Where(w => w.Id == id).FirstOrDefault()!;
            return Ok(instructorFilter);
        }

        /*[HttpPost]
        public ActionResult Post(InstructorEntity instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
            return Ok(instructor);
        }*/

        [HttpPut("{id}")]
        public ActionResult Put(InstructorEntity instructor)
        {
            _context.Instructors.Update(instructor);
            _context.SaveChanges();
            return Ok(instructor);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (_context.Instructors.Any(w => w.Id == id))
            {
                var instructorRemove = _context.Instructors.Where(w => w.Id == id).FirstOrDefault()!;

                _context.Instructors.Remove(instructorRemove);
                _context.SaveChanges();
            }
        }
    }
}
