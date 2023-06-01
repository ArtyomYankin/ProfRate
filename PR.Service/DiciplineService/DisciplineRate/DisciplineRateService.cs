using PR.Data;
using PR.Repository.DisciplineRate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Service.DisciplineService 
{
    public class DisciplineRateService : IDisciplineRateService
    {
        private readonly IDisciplineRateRepo _disciplineRateRepo;
        public DisciplineRateService(IDisciplineRateRepo disciplineRateRepo)
        {
            _disciplineRateRepo = disciplineRateRepo;
        }

        public void AddNewRate(DisciplineRating disciplineRating)
        {
            _disciplineRateRepo.AddNewRate(disciplineRating);
        }

        public List<DisciplineRating> GetDisciplineRates(int teacherid, int disciplineId)
        {
            return _disciplineRateRepo.GetDisciplineRates(teacherid, disciplineId);
        }

        public DisciplineRating GetDisciplineRating(int disciplineId, int teacherId)
        {
            return _disciplineRateRepo.GetDisciplineRate(disciplineId, teacherId);
        }
    }
}
