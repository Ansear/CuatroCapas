using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Services;
public interface IUserService
{
    Task<string> RegisterAsync(RegisterDto model);
    Task<DataUserDto> RegisterAsync(LoginDto model);
    Task<string> RegisterAsync(AddRoleDto model);
    Task<DataUserDto> RegisterAsync(string RefreshToken);
}