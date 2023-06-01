using Microsoft.AspNetCore.Mvc;
using PR.Data;
using PR.Service.DiciplineService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProffRate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherDisciplineController : ControllerBase
    {
        // GET: api/<TeacherDisciplineController>
        private ITeacherDisciplineService _teacherDisciplineService;

        public TeacherDisciplineController(ITeacherDisciplineService teacherDisciplineService)
        {
            _teacherDisciplineService = teacherDisciplineService;
        }

        [Route("GetDisciplines/{teacherId}")]
        public List<TeacherDisclipline> GetDisciplines(int teacherId)
        {
            var disciplines = _teacherDisciplineService.GetTeacherDisciplines(teacherId);
            return disciplines;
        }

        [Route("{teacherId}/{disciplineId}")]
        public TeacherDisclipline Get(int teacherId, int disciplineId)
        {
            var disciplines = _teacherDisciplineService.GetTeacherDisclipline(teacherId, disciplineId);
            return disciplines;
        }
        // POST api/<TeacherDisciplineController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpGet("{id}")]
        public TeacherDisclipline Get(int id)
        {
            var discipline = _teacherDisciplineService.GetTeacherDiscliplineById(id);
            return discipline;
        }

        // PUT api/<TeacherDisciplineController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeacherDisciplineController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
