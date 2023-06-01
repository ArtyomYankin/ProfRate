using PR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Service
{
    public interface IUserService
    {
        User AddUser(User user);
        User GetUser(User user);
        User GetById(string id);
    }
}
