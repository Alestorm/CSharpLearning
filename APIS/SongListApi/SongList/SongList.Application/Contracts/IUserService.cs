using SongList.Application.Dtos.UserDtos;
using SongList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongList.Application.Contracts
{
    public interface IUserService
    {
        Result<UserDto> RegisterUser(RegisterUserDto registerUserDto);
        Result<UserDto> Authenticate(LoginDto loginDto);
        Result<UserDto> GetUserById(int idUser);
        Result<UserDto> GetUserByEmail(string email);
    }
}
