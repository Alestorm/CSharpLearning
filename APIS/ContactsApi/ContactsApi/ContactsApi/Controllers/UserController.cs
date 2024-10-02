using ContactsApi.Controllers.Dtos.UserDtos;
using ContactsApi.Helpers;
using ContactsApi.Models;
using ContactsApi.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ContactsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _userRepository;
        public UserController(IUser userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost]
        public IActionResult RegisterUser([FromBody] RegisterUserDto registerUserDto)
        {
            try
            {
                User user = new User()
                {
                    Name = registerUserDto.Name,
                    Lastname = registerUserDto.Lastname,
                    Email = registerUserDto.Email,
                    Username = registerUserDto.Username,
                    Password = Encrypt.EncryptPassword(registerUserDto.Password),
                    Phone = registerUserDto.Phone,
                };
                return Created("", _userRepository.RegisterUser(user));
            }
            catch (InvalidOperationException ex)
            {
                return StatusCode(509, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] LoginDto loginDto)
        {
            try
            {
                var user = _userRepository.Authenticate(loginDto.Username, Encrypt.EncryptPassword(loginDto.Password));
                if (user == null)
                {
                    return Unauthorized("Invalid credentials");
                }
                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
