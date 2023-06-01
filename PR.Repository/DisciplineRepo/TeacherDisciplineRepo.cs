using PR.Data;
using PR.Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Repository.DisciplineRepo
{
    public class TeacherDisciplineRepo : ITeacherDisciplineRepo
    {
        private ApplicationContext _context;

        public TeacherDisciplineRepo(ApplicationContext applicationContext)
        {
            _context = applicationContext;
            if (!_context.TeacherDisciplines.Any())
            {
                _context.TeacherDisciplines.Add(new TeacherDisclipline { DisciplineId = 1, TeacherId = 1 });
                _context.TeacherDisciplines.Add(new TeacherDisclipline { DisciplineId = 2, TeacherId = 2 });
                _context.TeacherDisciplines.Add(new TeacherDisclipline { DisciplineId = 3, TeacherId = 1 });
                _context.TeacherDisciplines.Add(new TeacherDisclipline { DisciplineId = 4, TeacherId = 2 });
                _context.TeacherDisciplines.Add(new TeacherDisclipline { DisciplineId = 5, TeacherId = 3 });
                _context.TeacherDisciplines.Add(new TeacherDisclipline { DisciplineId = 6, TeacherId = 4 });
                _context.TeacherDisciplines.Add(new TeacherDisclipline { DisciplineId = 7, TeacherId = 4 });
                _context.SaveChanges();
            }
        }

        public TeacherDisclipline GetTeacherDisclipline(int teacherId, int disciplineId)
        {
            var teacherDiscipline = _context.TeacherDisciplines.FirstOrDefault(x => x.TeacherId == teacherId && x.DisciplineId == disciplineId);
            if (teacherDiscipline != null)
                return teacherDiscipline;
            return null;
        }

        public TeacherDisclipline GetTeacherDiscliplineById(int id)
        {
            return _context.TeacherDisciplines.FirstOrDefault(x => x.Id == id);
        }

        public List<TeacherDisclipline> GetTeacherDiscliplines(int teacherId)
        {
            return _context.TeacherDisciplines.Where(x => x.TeacherId == teacherId).ToList();
        }
    }
}
