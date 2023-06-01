using PR.Data;
using PR.Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Repository.TeacherRepo
{
    public class TeacherRepo : ITeacherRepo
    {
        private ApplicationContext _context;
        public TeacherRepo(ApplicationContext context)
        {
            _context = context;
            if (!_context.Teachers.Any())
            {
                _context.Teachers.Add(new Teacher { Name = "Чудовская Елена Аркадьевна", Department = "телекоммуникаций и информационных технологий", JobTitle = "Доцент" });
                _context.Teachers.Add(new Teacher { Name = "Афоненко Александр Анатольевич", Department = "квантовой радиофизики и оптоэлектроники", JobTitle = "Профессор" });
                _context.Teachers.Add(new Teacher { Name = "Яцков Николай Николаевич", Department = "системного анализа и компьютерного моделирования", JobTitle = "Заведующий" });
                _context.Teachers.Add(new Teacher { Name = "Мулярчик Степан Григорьевич", Department = "информатики и компьютерных систем", JobTitle = "Профессор" });
                _context.Teachers.Add(new Teacher { Name = "Демидчик Валерий Иосифович", Department = "радиофизики и цифровых медиа технологий", JobTitle = "Доцент" });
                _context.Teachers.Add(new Teacher { Name = "Семенчик Владимир Григорьевич", Department = "радиофизики и цифровых медиа технологий", JobTitle = "Доцент" });
                _context.Teachers.Add(new Teacher { Name = "Кочин Виктор Павлович", Department = "телекоммуникаций и информационных технологий", JobTitle = "Доцент" });
                _context.Teachers.Add(new Teacher { Name = "Мулярчик Константин Сергеввич", Department = "телекоммуникаций и информационных технологий", JobTitle = "Доцент" });
                _context.Teachers.Add(new Teacher { Name = "Резников Геннадий Константинович", Department = "телекоммуникаций и информационных технологий", JobTitle = "Доцент" });
                _context.Teachers.Add(new Teacher { Name = "Микулович Александр Владимирович", Department = "радиофизики и цифровых медиа технологий", JobTitle = "Старший преподаватель" });
                _context.Teachers.Add(new Teacher { Name = "Попко Елена Евгеньевна", Department = "телекоммуникаций и информационных технологий", JobTitle = "Старший преподаватель" });
                _context.Teachers.Add(new Teacher { Name = "Солодухо Никита Александрович", Department = "телекоммуникаций и информационных технологий", JobTitle = "Старший преподаватель" });
                _context.Teachers.Add(new Teacher { Name = "Труханович Алексей Леонидович", Department = "телекоммуникаций и информационных технологий", JobTitle = "Старший преподаватель" });
                _context.Teachers.Add(new Teacher { Name = "Шалатонин Иван Алексеевич", Department = "телекоммуникаций и информационных технологий", JobTitle = "Старший преподаватель" });
                _context.Teachers.Add(new Teacher { Name = "Воротницкий Юрий Иосифович", Department = "телекоммуникаций и информационных технологий", JobTitle = "Заведующий кафедрой" });
                _context.Teachers.Add(new Teacher { Name = "Соболь Александр Михайлович", Department = "телекоммуникаций и информационных технологий", JobTitle = "Старший преподаватель" });
                _context.Teachers.Add(new Teacher { Name = "Садов Василий Сергеевич", Department = "интеллектуальных систем", JobTitle = "Доцент" });
                _context.SaveChanges();
            }
        }

        public void Create(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            Save();
        }

        public void Delete(int id)
        {
            Teacher teacher = _context.Teachers.Find(id);
            if (teacher != null)
                _context.Teachers.Remove(teacher);
        }

        public List<Teacher> GetAllTeachers()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetTeacher(int id)
        {
            return _context.Teachers.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Teacher teacher)
        {
            _context.Entry(teacher).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
