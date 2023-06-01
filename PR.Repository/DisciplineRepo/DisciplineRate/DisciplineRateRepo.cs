using PR.Data;
using PR.Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Repository.DisciplineRate
{
    public class DisciplineRateRepo : IDisciplineRateRepo
    {
        private ApplicationContext _applicationContext;
        public DisciplineRateRepo(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void AddNewRate(DisciplineRating disciplineRating)
        {
            disciplineRating.Created = DateTime.Now;
            disciplineRating.AverageDisciplineRate = (disciplineRating.ActualizationRate + disciplineRating.BenefitRate + disciplineRating.InterestingnessRate) / 3;
            _applicationContext.DisciplineRatings.Add(disciplineRating);
            _applicationContext.SaveChanges();
        }

        public DisciplineRating GetDisciplineRate(int disciplineId, int teacherId)
        {
           return _applicationContext.DisciplineRatings.FirstOrDefault(x=>x.DisciplineId == disciplineId && x.TeacherId == teacherId);
        }

        public List<DisciplineRating> GetDisciplineRates(int teacherId, int disciplineId)
        {
            return _applicationContext.DisciplineRatings.Where(x => x.DisciplineId == disciplineId && x.TeacherId == teacherId).ToList();
        }
    }
}
