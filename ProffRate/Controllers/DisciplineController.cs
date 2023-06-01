using Microsoft.AspNetCore.Mvc;
using PR.Data;
using PR.Service.DiciplineService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProffRate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplineController : ControllerBase
    {
        // GET: api/<DisciplineController>
        private IDisciplineService _disciplineService;
        public DisciplineController(IDisciplineService disciplineService)
        {
            _disciplineService = disciplineService;
        }
        // GET api/<DisciplineController>/5
        [HttpGet("{id}")]
        public Discipline Get(int id)
        {
            var a = _disciplineService.GetDiscipline(id);
            return a;
        }

        // POST api/<DisciplineController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DisciplineController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DisciplineController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
