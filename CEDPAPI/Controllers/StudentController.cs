using CEDPAPI.Context;
using CEDPAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CEDPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly CEdpApiContext _context;

        public StudentController(CEdpApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.Students);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var gradeFilter = _context.Students.Where(w => w.Id == id).FirstOrDefault()!;
            return Ok(gradeFilter);
        }

        [HttpPost]
        public ActionResult Post(StudentEntity student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Ok(student);
        }

        [HttpPut("{id}")]
        public ActionResult Put(StudentEntity student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (_context.Students.Any(w => w.Id == id))
            {
                var studentRemove = _context.Students.Where(w => w.Id == id).FirstOrDefault()!;

                _context.Students.Remove(studentRemove);
                _context.SaveChanges();
            }
        }
    }
}
