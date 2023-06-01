using PR.Data;
using PR.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _loginRepository;
        public UserService(IUserRepo loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public User AddUser(User user)
        {
            return _loginRepository.Add(user); ;
        }

        public  User GetById(string id)
        {
            var user = _loginRepository.GetById(id);
            return user;
        }

        public User GetUser(User user)
        {
            var userToGet = _loginRepository.Get(user);
            return userToGet;
        }
    }
}
