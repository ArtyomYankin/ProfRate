using PR.Data;
using PR.Repository.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR.Repository
{
    public class UserRepo : IUserRepo
    {
        private ApplicationContext _context;
        public UserRepo(ApplicationContext context)
        {
            _context = context;
        }
        public User Add(User entity)
        {
            if (_context.Users.Contains(entity))
                return _context.Users.Find(entity);
            var user = _context.Users.Add(entity).Entity;
            Save();
            return user;
        }

        public User Get(User entity)
        {
            return _context.Users.FirstOrDefault();
        }

        public User GetById(string id)
        {
            return _context.Users.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
