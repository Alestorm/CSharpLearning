using SongList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Domain.Contracts
{
    public interface IUserSong
    {
        /// <summary>
        /// Adds a song to the table UserSong, wich contains the favorite songs from users
        /// </summary>
        /// <param name="idUser">User id</param>
        /// <param name="idSong">Song id</param>
        /// <returns></returns>
        Result<UserSong> AddFavorite(int idUser, int idSong);

        /// <summary>
        /// Deletes a song from the table UserSong, wich contains the favorite songs from users
        /// </summary>
        /// <param name="idUser"></param>
        /// <param name="idSong"></param>
        /// <returns></returns>
        Result<bool> DeleteFavorite(int idUser, int idSong);
    }
}
