using SongList.Domain.Contracts;
using SongList.Domain.Entities;
using SongList.Infrastructure.MySqlDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Infrastructure.Repositories
{
    public class SongRepository : ISong
    {
        private readonly MySqlDbContext _context;
        public SongRepository(MySqlDbContext context)
        {
            _context = context;
        }
        public Result<Song> AddSong(Song song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
            return Result<Song>.Success(song);

        }

        public Result<Song> GetSongById(int idSong)
        {
            var song = _context.Songs.FirstOrDefault(s => s.IdSong == idSong);
            if (song == null)
            {
                return Result<Song>.Failure("Song not found");
            }
            return Result<Song>.Success(song);
        }

        public Result<Song> GetSongByTitle(string title)
        {
            var song = _context.Songs.FirstOrDefault(s => s.Title.ToLower().Equals(title.ToLower()));
            if (song == null)
            {
                return Result<Song>.Failure("Song not found");
            }
            return Result<Song>.Success(song);
        }

        public Result<List<Song>> ListSongs()
        {
            var songs = _context.Songs.ToList();
            return Result<List<Song>>.Success(songs);
        }
    }
}
