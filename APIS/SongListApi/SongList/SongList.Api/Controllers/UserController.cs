using Microsoft.AspNetCore.Mvc;
using SongList.Application.Contracts;
using SongList.Application.Dtos.UserDtos;

namespace SongList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public IActionResult RegisterUser([FromBody] RegisterUserDto registerUserDto)
        {
            if (registerUserDto.Email.Length < 2)
            {
                return BadRequest("Invalid email");
            }
            if (registerUserDto.Password.Length < 3)
            {
                return BadRequest("Password must have at least 3 characters");
            }
            if (registerUserDto.Username.Length < 4)
            {
                return BadRequest("Username must have at least 3 characters");
            }

            var result = _userService.RegisterUser(registerUserDto);
            return Ok(result.Value);
        }
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] LoginDto loginDto)
        {
            if (loginDto.Password.Length < 3)
            {
                return BadRequest("Password must have at least 3 characters");
            }
            if (loginDto.Username.Length < 4)
            {
                return BadRequest("Password must have at least 3 characters");
            }
            var result = _userService.Authenticate(loginDto);
            if (!result.IsSuccess)
            {
                return StatusCode(403, result.ErrorMessage);
            }
            return Ok(result.Value);
        }
        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute] int id)
        {
            var result = _userService.GetUserById(id);
            if (!result.IsSuccess)
            {
                return NotFound(result.ErrorMessage);
            }
            return Ok(result.Value);
        }
        [HttpGet("email")]
        public IActionResult GetUserByEmail([FromQuery] string email)
        {
            if (email.Length < 2)
            {
                return BadRequest("Invalid email");
            }
            var result = _userService.GetUserByEmail(email);
            if (!result.IsSuccess)
            {
                return NotFound(result.ErrorMessage);
            }
            return Ok(result.Value);
        }
    }
}
