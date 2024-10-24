using Microsoft.AspNetCore.Mvc;
using MoviesApi.Controllers.Dtos.RatingDtos;
using MoviesApi.Domain.Contracts;

namespace MoviesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRating _ratingRepository;
        public RatingController(IRating ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }
        [HttpPost]
        public IActionResult AddRating([FromBody] NewRatingDto newRatingDto)
        {
            try
            {
                if (newRatingDto.Rate < 0 || newRatingDto.Rate > 10)
                {
                    return BadRequest("Rate must be between 0 and 10");
                }
                return Created("", _ratingRepository.AddRating(newRatingDto.IdMovie, newRatingDto.Rate));
            }
            catch (KeyNotFoundException ex)
            {
                return StatusCode(404, ex.Message);
            }
        }
    }
}