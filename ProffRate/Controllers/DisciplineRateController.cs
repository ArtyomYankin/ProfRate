using Microsoft.AspNetCore.Mvc;
using PR.Data;
using PR.Service.DisciplineService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProffRate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplineRateController : ControllerBase
    {
        private readonly IDisciplineRateService _disciplineRateService;
        public DisciplineRateController(IDisciplineRateService disciplineRateService)
        {
            _disciplineRateService = disciplineRateService;
        }

        [Route("GetRates/{teacherId}/{disciplineId}")]
        public List<DisciplineRating> GetRates(int teacherId, int disciplineId)
        {
            var disciplineRatings = _disciplineRateService.GetDisciplineRates(teacherId, disciplineId);
            return disciplineRatings;
        }

        // GET api/<DisciplineRateController>/5
        [HttpGet("{disciplineId}, {teacherId}")]
        public Object Get(int disciplineId, int teacherId)
        {
            var disciplineRate = _disciplineRateService.GetDisciplineRating(disciplineId, teacherId);
            return disciplineRate;
        }

        [HttpPost]
        public void PostRate(DisciplineRating disciplineRating)
        {
            _disciplineRateService.AddNewRate(disciplineRating);

        }

        // PUT api/<DisciplineRateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DisciplineRateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
