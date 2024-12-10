using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Application.Dtos.SongDtos
{
    public class SongDto
    {
        public int IdSong { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public DateTime CreationDate { get; set; }
    }
}