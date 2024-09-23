using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.TasksManager.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new List<User>();
        public void Add(User user)
        {
            _users.Add(user);
        }

        public void DeleteUserById(int idUser)
        {
            var user = _users.FirstOrDefault(u => u.IdUser == idUser);
            if (user == null)
            {
                Console.WriteLine("The user doesn't exist");
                return;
            }
            _users.Remove(user);
            Console.WriteLine("User removed");
        }

        public User GetUserById(int idUser)
        {
            var user = _users.FirstOrDefault(u => u.IdUser == idUser);
            return user != null ? user : null;
        }

        public void UpdateUser(int idUser, User user)
        {
            var findUser = _users.FirstOrDefault(u => u.IdUser == idUser);
            if (user == null)
            {
                Console.WriteLine("The user doesn't exist");
                return;
            }
            findUser.Name = user.Name;
            findUser.Lastname = user.Lastname;
            findUser.Email = user.Email;
            findUser.Username = user.Username;
            findUser.Password = user.Password;
            findUser.Phone = user.Phone;
            findUser.Address = user.Address;
        }
    }
}
