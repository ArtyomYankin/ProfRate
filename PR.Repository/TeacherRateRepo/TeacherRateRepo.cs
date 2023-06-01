using PR.Data;
using PR.Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Repository.TeacherRate
{
    public class TeacherRateRepo : ITeacherRateRepo
    {
        private ApplicationContext _context;
        public TeacherRateRepo(ApplicationContext context)
        {
            _context = context;
            if (!_context.Disciplines.Any())
            {
                _context.Disciplines.Add(new Discipline { DisciplineName = "Моделирование телекоммуникационных систем", DisciplineDescription = "Кафедра телекоммуникаций и информационных технологий" });
                _context.Disciplines.Add(new Discipline { DisciplineName = "Операционные системы", DisciplineDescription = "Кафедра телекоммуникаций и информационных технологий" });
                _context.Disciplines.Add(new Discipline { DisciplineName = "Компьютерные сети", DisciplineDescription = "Кафедра телекоммуникаций и информационных технологий" });
                _context.Disciplines.Add(new Discipline { DisciplineName = "Программно-аппаратные средства обеспечения информационной безопасности", DisciplineDescription = "Кафедра интеллектуальных систем" });
                _context.Disciplines.Add(new Discipline { DisciplineName = "Безопасность информационных систем", DisciplineDescription = "Кафедра интеллектуальных систем" });
                _context.Disciplines.Add(new Discipline { DisciplineName = "Интегральная электроника", DisciplineDescription = "Кафедра интеллектуальных систем" });
                _context.Disciplines.Add(new Discipline { DisciplineName = "Компьютерная стеганография и прикладная криптография", DisciplineDescription = "Кафедра интеллектуальных систем" });
                _context.SaveChanges();
            }
        }

        public void Create(TeacherRating teacherRate)
        {
            _context.Teachers.FirstOrDefault(x => x.TeacherId == teacherRate.TeacherId).TeacherRatings.Add(teacherRate);
            Save();
        }

        public List<TeacherRating> GetTeacherRatings(int id)
        {
            return _context.TeacherRatings.Where(x=>x.TeacherId == id).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(TeacherRating teacherRate)
        {
            teacherRate.AverageTeacherRating = (teacherRate.OrganizationRate + teacherRate.CommunicationRate + teacherRate.InterestingnessRate) / 3;
            teacherRate.Created = DateTime.Now;
            _context.TeacherRatings.Add(teacherRate);
            Save();
        }
    }
}
