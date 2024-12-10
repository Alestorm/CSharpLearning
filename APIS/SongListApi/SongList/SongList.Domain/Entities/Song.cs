using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Domain.Entities
{
    public class Song
    {
        public int IdSong { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public DateTime CreationDate { get; set; }

        public ICollection<UserSong> UserSongs { get; set; }
    }
}
