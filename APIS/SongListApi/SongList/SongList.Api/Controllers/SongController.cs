

using Microsoft.AspNetCore.Mvc;
using SongList.Application.Contracts;
using SongList.Application.Dtos.SongDtos;

namespace SongList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly ISongService _songService;
        public SongController(ISongService songService)
        {
            _songService = songService;
        }
        [HttpPost]
        public IActionResult AddSong([FromBody] AddSongDto addSongDto)
        {
            if (addSongDto.Title.Length < 2)
            {
                return BadRequest("Title must have at least 2 characters");
            }
            if (addSongDto.Artist.Length < 2)
            {
                return BadRequest("Artist must have at least 2 characters");
            }
            if (addSongDto.Album.Length < 2)
            {
                return BadRequest("Album must have at least 2 characters");
            }
            if (addSongDto.Duration <= 0)
            {
                return BadRequest("Duration must be greater than zero");
            }
            if (addSongDto.Duration > 1800)
            {
                return BadRequest("Incorrect year");
            }
            var result = _songService.AddSong(addSongDto);

            return Ok(result.Value);
        }
        [HttpGet]
        public IActionResult ListSongs()
        {
            var result = _songService.ListSongs();
            if (result.Value.Count <= 0)
            {
                return NoContent();
            }
            return Ok(result.Value);
        }
    }
}