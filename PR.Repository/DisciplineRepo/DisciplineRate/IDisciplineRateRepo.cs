using PR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Repository.DisciplineRate
{
    public interface IDisciplineRateRepo
    {
        DisciplineRating GetDisciplineRate(int disciplineId, int teacherId);
        List<DisciplineRating> GetDisciplineRates(int teacherId, int disciplineId);
        void AddNewRate(DisciplineRating disciplineRating);
    }
}
