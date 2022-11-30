using CEDPAPI.Context;
using CEDPAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CEDPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly CEdpApiContext _context;

        public GradeController(CEdpApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.Grades);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var gradeFilter = _context.Grades.Where(w => w.Id == id).FirstOrDefault()!;
            return Ok(gradeFilter);
        }

        /*[HttpPost]
        public ActionResult Post(GradeEntity grade)
        {
            _context.Grades.Add(grade);
            _context.SaveChanges();
            return Ok(grade);
        }*/

        [HttpPut("{id}")]
        public ActionResult Put(GradeEntity grade)
        {
            _context.Grades.Update(grade);
            _context.SaveChanges();
            return Ok(grade);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (_context.Grades.Any(w => w.Id == id))
            {
                var gradeRemove = _context.Grades.Where(w => w.Id == id).FirstOrDefault()!;

                _context.Grades.Remove(gradeRemove);
                _context.SaveChanges();
            }
        }
    }
}
