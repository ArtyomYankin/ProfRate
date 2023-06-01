using PR.Data;
using PR.Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Repository.DisciplineRepo
{
    public class DisciplineRepo : IDisciplineRepo
    {
        private ApplicationContext _context;

        public DisciplineRepo(ApplicationContext context)
        {
            _context = context;
            
        }

        public void Create(Discipline discipline)
        {
            _context.Add(discipline);
            Save();
        }

        public void Delete(int id)
        {
            Discipline discipline = _context.Disciplines.Find(id);
            if (discipline != null)
                _context.Disciplines.Remove(discipline);
            Save();
        }

        public Discipline GetDiscipline(int diciplineId)
        {
            return _context.Disciplines.FirstOrDefault(x => x.DisciplineId == diciplineId); ;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Discipline discipline)
        {
            throw new NotImplementedException();
        }
    }
}
