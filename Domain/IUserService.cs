using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskVardan.DataAccess;
using TaskVardan.Domain.Models;

namespace TaskVardan.Domain
{
    public interface IUserService
    {
        Task<UserDto> Login(LoginDto request);
        Task<UserDto> Register(RegistrationDto request);
    }
}
