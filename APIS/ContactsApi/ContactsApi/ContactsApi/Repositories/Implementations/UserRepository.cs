using ContactsApi.Models;
using ContactsApi.Models.Interfaces;
using ContactsApi.Repositories.Database;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApi.Repositories.Implementations
{
    public class UserRepository : IUser
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public User Authenticate(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password)) ?? null;
            return user;
        }

        public void DeleteUser(int idUser)
        {
            throw new NotImplementedException();
        }

        public User RegisterUser(User user)
        {
            if (_context.Users.Any(u => u.Email.Equals(user.Email) || u.Username.Equals(user.Username)))
            {
                throw new InvalidOperationException("User already exists");
            }

            _context.Users.Add(user);
            _context.SaveChanges();
            return user;

        }




        public User GetUser(int idUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.IdUser == idUser) ?? null;
            return user;
        }

        public void ChangePassword(User user, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}
