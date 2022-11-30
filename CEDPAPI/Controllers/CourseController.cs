using CEDPAPI.Context;
using CEDPAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CEDPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CEdpApiContext _context;

        public CourseController(CEdpApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.Courses);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var courseFilter = _context.Courses.Where(w => w.Id == id).FirstOrDefault()!;
            return Ok(courseFilter);
        }

        [HttpPost]
        public ActionResult Post(CourseEntity course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return Ok(course);
        }

        [HttpPut("{id}")]
        public ActionResult Put(CourseEntity course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
            return Ok(course);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (_context.Courses.Any(w => w.Id == id))
            {
                var courseRemove = _context.Courses.Where(w => w.Id == id).FirstOrDefault()!;

                _context.Courses.Remove(courseRemove);
                _context.SaveChanges();
            }
        }
    }
}
