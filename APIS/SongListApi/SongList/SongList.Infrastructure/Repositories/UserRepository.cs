using SongList.Domain.Contracts;
using SongList.Domain.Entities;
using SongList.Infrastructure.MySqlDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Infrastructure.Repositories
{
    public class UserRepository : IUser
    {
        private readonly MySqlDbContext _context;
        public UserRepository(MySqlDbContext context)
        {
            _context = context;
        }
        public Result<User> Authenticate(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
            if (user == null)
            {
                return Result<User>.Failure("Invalid credentials");
            }
            return Result<User>.Success(user);
        }

        public Result<User> GetUserByEmail(string email)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email.Equals(email));
            if (user == null)
            {
                return Result<User>.Failure("No user found");
            }
            return Result<User>.Success(user);
        }

        public Result<User> GetUserById(int idUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.IdUser == idUser);
            if (user == null)
            {
                return Result<User>.Failure("No user found");
            }
            return Result<User>.Success(user);
        }

        public Result<User> RegisterUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Result<User>.Success(user);
        }
    }
}
