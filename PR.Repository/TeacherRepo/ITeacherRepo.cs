using PR.Data;
namespace PR.Repository
{
    public interface ITeacherRepo
    {
        List<Teacher> GetAllTeachers();
        Teacher GetTeacher(int id);
        void Create(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(int id);
        void Save();
    }
}
