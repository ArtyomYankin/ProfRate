using PR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Service.DiciplineService
{
    public interface IDisciplineService
    {
        Discipline GetDiscipline(int diciplineId);
    }
}
