using PR.Data;
using PR.Repository.DisciplineRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Service.DiciplineService
{
    public class DisciplineService : IDisciplineService
    {
        private IDisciplineRepo _diciplineRepo;
        public DisciplineService (IDisciplineRepo disciplineRepo)
        {
            _diciplineRepo = disciplineRepo;
        }
        public Discipline GetDiscipline(int diciplineId)
        {
            return _diciplineRepo.GetDiscipline(diciplineId);
        }
    }
}
