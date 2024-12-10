using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Domain.Entities
{
    public class UserSong
    {
        public int IdUser{ get; set; }
        public User User { get; set; }

        public int IdSong { get; set; }
        public Song Song { get; set; }

    }
}
