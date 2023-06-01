using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PR.Data;
using PR.Repository;
using PR.Service.TeacherService;

namespace ProffRate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet()]
        public List<Teacher> Get()
        {
            var teachers = _teacherService.GetTeachers();
            return teachers;
        }
        [HttpGet("{id}")]
        public Teacher GetTeacher(int id)
        {
            var teacher = _teacherService.GetTeacher(id);
            return teacher;
        }
        [HttpPost]
        public void PostTeacher(Teacher teacher)
        {
            _teacherService.CreateTeacher(teacher);
        }
        [HttpDelete("{id}")]
        public void DeleteTeacher(int id)
        {
            _teacherService.RemoveTeacher(id);
        }
    }
}
