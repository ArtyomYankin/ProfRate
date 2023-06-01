using PR.Data;
using PR.Repository.DisciplineRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Service.DiciplineService
{
    public class TeacherDisciplineService : ITeacherDisciplineService
    {
        private ITeacherDisciplineRepo _teacherDisciplineRepo;

        public TeacherDisciplineService(ITeacherDisciplineRepo teacherDisciplineRepo)
        {
            _teacherDisciplineRepo = teacherDisciplineRepo;
        }

        public List<TeacherDisclipline> GetTeacherDisciplines(int teacherId)
        {
            return _teacherDisciplineRepo.GetTeacherDiscliplines(teacherId);
        }

        public TeacherDisclipline GetTeacherDisclipline(int teacherId, int disciplineId)
        {
            return _teacherDisciplineRepo.GetTeacherDisclipline(teacherId, disciplineId);
        }

        public TeacherDisclipline GetTeacherDiscliplineById(int id)
        {
            return _teacherDisciplineRepo.GetTeacherDiscliplineById(id);
        }
    }
}
