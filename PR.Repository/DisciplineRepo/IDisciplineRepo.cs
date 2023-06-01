using PR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Repository.DisciplineRepo
{
    public interface IDisciplineRepo
    {
        Discipline GetDiscipline(int disciplineId);
        void Create(Discipline discipline);
        void Update(Discipline discipline);
        void Delete(int id);
        void Save();


    }
}
