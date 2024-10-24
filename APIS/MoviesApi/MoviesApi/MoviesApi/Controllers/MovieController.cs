

using Microsoft.AspNetCore.Mvc;
using MoviesApi.Controllers.Dtos.MovieDtos;
using MoviesApi.Domain;
using MoviesApi.Domain.Contracts;
using MoviesApi.Infrastructure.Repositories;

namespace MoviesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly IMovie _movieRepository;
        public MovieController(IMovie movieRepository)
        {
            _movieRepository = movieRepository;
        }
        [HttpPost]
        public IActionResult AddMovie([FromBody] NewMovieDto newMovieDto)
        {
            Movie movie = new()
            {
                Title = newMovieDto.Title,
                Director = newMovieDto.Director,
                Year = newMovieDto.Year,
                Duration = newMovieDto.Duration,
                Genre = newMovieDto.Genre
            };
            return Created("", _movieRepository.AddMovie(movie));
        }
        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            var moviesDto = movies.Select(m => new MovieDto()
            {
                IdMovie = m.IdMovie,
                Title = m.Title,
                Director = m.Director,
                Year = m.Year,
                Duration = m.Duration,
                Genre = m.Genre,
                Rating = GetRating(m.Ratings)
            }).ToList();
            return Ok(moviesDto);
        }
        [HttpGet("{id}")]
        public IActionResult GetMovie([FromRoute] int id)
        {
            try
            {
                var m = _movieRepository.GetMovie(id);
                var movieDto = new MovieDto()
                {
                    IdMovie = m.IdMovie,
                    Title = m.Title,
                    Director = m.Director,
                    Year = m.Year,
                    Duration = m.Duration,
                    Genre = m.Genre,
                    Rating = GetRating(m.Ratings)
                };
                return Ok(movieDto);
            }
            catch (KeyNotFoundException ex)
            {
                return StatusCode(404, ex.Message);
            }
        }
        private double GetRating(ICollection<Rating> ratings)
        {
            return ratings != null && ratings.Count > 0 ? Math.Round((double)ratings.Sum(r => r.Rate) / ratings.Count, 2) : 0;
        }
    }
}
