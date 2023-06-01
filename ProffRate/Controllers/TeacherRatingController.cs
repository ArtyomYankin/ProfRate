using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PR.Data;
using PR.Repository;
using PR.Service.TeacherRate;

namespace ProffRate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherRatingController : ControllerBase
    {
        private readonly ITeacherRateService _teacherRateService;

        public TeacherRatingController(ITeacherRateService teacherRateService)
        {
            _teacherRateService = teacherRateService;
        }

        [HttpGet("{id}")]
        public List<TeacherRating> GetTeacherRatings(int id)
        {
            var teacher = _teacherRateService.GetTeacherRatings(id);
            return teacher;
        }
        [HttpPost]
        public void PostTeacher(TeacherRating teacherRating)
        {
            _teacherRateService.UpdateTeacherRate(teacherRating);
            
        }
        //[HttpDelete("{id}")]
        //public void DeleteTeacher(int id)
        //{
        //    _teacherRateService.RemoveTeacher(id);
        //}
    }
}
