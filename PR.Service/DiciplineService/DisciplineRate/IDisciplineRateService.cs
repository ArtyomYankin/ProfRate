using PR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Service.DisciplineService
{
    public interface IDisciplineRateService
    {
        DisciplineRating GetDisciplineRating(int disciplineId, int teacherId);
        List<DisciplineRating> GetDisciplineRates(int teacherId, int disciplineId);
        void AddNewRate(DisciplineRating disciplineRating);
    }
}
