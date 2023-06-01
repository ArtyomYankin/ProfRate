using PR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Repository.DisciplineRepo
{
    public interface ITeacherDisciplineRepo
    {
        List<TeacherDisclipline> GetTeacherDiscliplines(int teacherId);
        TeacherDisclipline GetTeacherDisclipline(int teacherId, int disciplineId);
        TeacherDisclipline GetTeacherDiscliplineById(int id);
    }
}
