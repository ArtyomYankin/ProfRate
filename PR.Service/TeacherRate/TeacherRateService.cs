using PR.Data;
using PR.Repository.TeacherRate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Service.TeacherRate
{
    public class TeacherRateService : ITeacherRateService
    {
        private readonly ITeacherRateRepo _teacherRateRepo;
        public TeacherRateService(ITeacherRateRepo teacherRateRepo)
        {
            _teacherRateRepo = teacherRateRepo;
        }
        public List<TeacherRating> GetTeacherRatings(int id)
        {
            return _teacherRateRepo.GetTeacherRatings(id);
        }

        public void UpdateTeacherRate(TeacherRating teacherRating)
        {
            _teacherRateRepo.Update(teacherRating);
        }
    }
}
