using SongList.Application.Contracts;
using SongList.Application.Dtos.SongDtos;
using SongList.Domain.Contracts;
using SongList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Application.Services
{
    public class SongService : ISongService
    {
        private readonly ISong _songRepository;
        public SongService(ISong songRepository)
        {
            _songRepository = songRepository;
        }
        public Result<SongDto> AddSong(AddSongDto addSongDto)
        {

            var result = _songRepository.AddSong(new Song()
            {
                Title = addSongDto.Title,
                Artist = addSongDto.Artist,
                Album = addSongDto.Album,
                Year = addSongDto.Year,
                Duration = addSongDto.Duration
            });

            if (!result.IsSuccess)
            {
                return Result<SongDto>.Failure(result.ErrorMessage);
            }
            var song = result.Value;
            return Result<SongDto>.Success(SongToDto(song));
        }

        public Result<SongDto> GetSongById(int idSong)
        {
            var result = _songRepository.GetSongById(idSong);
            if (!result.IsSuccess)
            {
                return Result<SongDto>.Failure(result.ErrorMessage);
            }

            var song = result.Value;
            return Result<SongDto>.Success(SongToDto(song));
        }

        public Result<SongDto> GetSongByTitle(string title)
        {
            var result = _songRepository.GetSongByTitle(title);
            if (!result.IsSuccess)
            {
                return Result<SongDto>.Failure(result.ErrorMessage);
            }
            var song = result.Value;
            return Result<SongDto>.Success(SongToDto(song));
        }

        public Result<List<SongDto>> ListSongs()
        {
            var result = _songRepository.ListSongs();
            if (!result.IsSuccess)
            {
                return Result<List<SongDto>>.Failure(result.ErrorMessage);
            }
            var songs = result.Value;
            List<SongDto> songsDto = songs.Select(SongToDto).ToList();
            return Result<List<SongDto>>.Success(songsDto);
        }


        /// <summary>
        /// Mapper: maps a Song to SongDto
        /// </summary>
        /// <param name="song">Song object</param>
        /// <returns></returns>
        private static SongDto SongToDto(Song song)
        {
            return new SongDto()
            {
                IdSong = song.IdSong,
                Title = song.Title,
                Artist = song.Artist,
                Album = song.Album,
                Year = song.Year,
                Duration = song.Duration,
                CreationDate = song.CreationDate
            };
        }
    }
}
