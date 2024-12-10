using SongList.Application.Contracts;
using SongList.Application.Dtos.UserDtos;
using SongList.Domain.Contracts;
using SongList.Domain.Entities;
using SongList.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUser _userRepository;
        public UserService(IUser userRepository)
        {
            _userRepository = userRepository;
        }
        public Result<UserDto> Authenticate(LoginDto loginDto)
        {
            loginDto.Password = Encrypt.EncryptPassword(loginDto.Password);
            var result = _userRepository.Authenticate(loginDto.Username, loginDto.Password);
            if (!result.IsSuccess)
            {
                return Result<UserDto>.Failure(result.ErrorMessage);
            }
            User user = result.Value;
            UserDto userDto = new UserDto()
            {
                IdUser = user.IdUser,
                Username = user.Username,
                Email = user.Email,
                CreationDate = DateTime.Now,
            };
            return Result<UserDto>.Success(userDto);
        }

        public Result<UserDto> GetUserByEmail(string email)
        {
            var result = _userRepository.GetUserByEmail(email);
            if (!result.IsSuccess)
            {
                return Result<UserDto>.Failure(result.ErrorMessage);
            }
            var user = result.Value;
            return Result<UserDto>.Success(new UserDto()
            {
                IdUser = user.IdUser,
                Username = user.Username,
                Email = user.Email,
                CreationDate = DateTime.Now,
            });
        }

        public Result<UserDto> GetUserById(int idUser)
        {
            var result = _userRepository.GetUserById(idUser);
            if (!result.IsSuccess)
            {
                return Result<UserDto>.Failure(result.ErrorMessage);
            }
            var user = result.Value;
            return Result<UserDto>.Success(new UserDto()
            {
                IdUser = user.IdUser,
                Username = user.Username,
                Email = user.Email,
                CreationDate = DateTime.Now,
            });
        }

        public Result<UserDto> RegisterUser(RegisterUserDto registerUserDto)
        {
            registerUserDto.Password = Encrypt.EncryptPassword(registerUserDto.Password);

            var result = _userRepository.RegisterUser(new User()
            {
                Username = registerUserDto.Username,
                Email = registerUserDto.Email,
                Password = registerUserDto.Password,
            });
            var user = result.Value;

            return Result<UserDto>.Success(new UserDto()
            {
                IdUser = user.IdUser,
                Username = user.Username,
                Email = user.Email,
                CreationDate = DateTime.Now,
            });
        }
    }
}
