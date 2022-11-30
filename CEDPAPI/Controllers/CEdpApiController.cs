using CEDPAPI.Context;
using CEDPAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CEDPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CEdpApiController : ControllerBase
    {
        private readonly CEdpApiContext _context;
        // GET: api/<CEdpApiController>
        [HttpGet]
        public IEnumerable<string> Get(CEdpApiContext context)
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CEdpApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CEdpApiController>
        [HttpPost]
        public RegistrationEntity Post(RegistrationEntity value)
        {
            _context.teste.Add(value);
            _context.SaveChanges();
            return value;
        }

        // PUT api/<CEdpApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CEdpApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
