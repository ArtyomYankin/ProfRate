using PR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Service.TeacherRate
{
    public interface ITeacherRateService
    {
        List<TeacherRating> GetTeacherRatings(int id);
        void UpdateTeacherRate(TeacherRating teacherRating);
    }
}
