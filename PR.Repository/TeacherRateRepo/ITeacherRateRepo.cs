using PR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Repository.TeacherRate
{
    public interface ITeacherRateRepo
    {
        List<TeacherRating> GetTeacherRatings(int id);
        void Create(TeacherRating teacher);
        void Update(TeacherRating teacher);
        void Save();
    }
}
