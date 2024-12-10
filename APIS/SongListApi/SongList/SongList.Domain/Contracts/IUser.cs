using SongList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Domain.Contracts
{
    public interface IUser
    {
        /// <summary>
        /// Adds a user in the database
        /// </summary>
        /// <param name="user">Object User</param>
        /// <returns></returns>
        Result<User> RegisterUser(User user);

        /// <summary>
        /// Used for login a user
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        /// <returns></returns>
        Result<User> Authenticate(string username, string password);

        /// <summary>
        /// Finds a user by its id
        /// </summary>
        /// <param name="idUser">User id</param>
        /// <returns></returns>
        Result<User> GetUserById(int idUser);

        /// <summary>
        /// Finds a user by its email
        /// </summary>
        /// <param name="email">User email</param>
        /// <returns></returns>
        Result<User> GetUserByEmail(string email);
    }
}