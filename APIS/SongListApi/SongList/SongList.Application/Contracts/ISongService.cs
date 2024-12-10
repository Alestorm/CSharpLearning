using SongList.Application.Dtos.SongDtos;
using SongList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Application.Contracts
{
    public interface ISongService
    {
        Result<SongDto> AddSong(AddSongDto addSongDto);

        Result<List<SongDto>> ListSongs();

        Result<SongDto> GetSongById(int idSong);

        Result<SongDto> GetSongByTitle(string title);
    }
}
