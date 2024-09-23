using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.TasksManager.Repository
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetUserById(int idUser);
        void UpdateUser(int idUser,User user);
        void DeleteUserById(int idUser);
    }
}
