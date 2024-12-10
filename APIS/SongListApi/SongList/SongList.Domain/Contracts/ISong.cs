using SongList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Domain.Contracts
{
    public interface ISong
    {
        /// <summary>
        /// Adds a song to the database
        /// </summary>
        /// <param name="song">Object Song</param>
        /// <returns></returns>
        Result<Song> AddSong(Song song);

        /// <summary>
        /// Returns the list of songs in database
        /// </summary>
        /// <returns></returns>
        Result<List<Song>> ListSongs();

        /// <summary>
        /// Returns the song with the given id, if exists
        /// </summary>
        /// <param name="idSong">Id of the song</param>
        /// <returns></returns>
        Result<Song> GetSongById(int idSong);

        /// <summary>
        /// Returns a song by it's title, if exists
        /// </summary>
        /// <param name="title">Title of the song</param>
        /// <returns></returns>
        Result<Song> GetSongByTitle(string title);
    }
}
