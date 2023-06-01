using PR.Data;
using PR.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Service.TeacherService
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepo _teacherRepo;
        public TeacherService(ITeacherRepo teacherRepo)
        {
            _teacherRepo = teacherRepo;
        }

        public void CreateTeacher(Teacher teacher)
        {
            _teacherRepo.Create(teacher);
        }

        public Teacher GetTeacher(int id)
        {
            return _teacherRepo.GetTeacher(id);
        }

        public List<Teacher> GetTeachers()
        {
            return _teacherRepo.GetAllTeachers();
        }

        public void RemoveTeacher(int id)
        {
            _teacherRepo.Delete(id);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _teacherRepo.Update(teacher);
        }
    }
}

