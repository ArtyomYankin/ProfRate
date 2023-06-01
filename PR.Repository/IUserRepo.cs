using PR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Repository
{
    public interface IUserRepo
    {
        User Add(User entity);
        User Get(User entity);
        User GetById(string id);
        void Save();
    }
}
