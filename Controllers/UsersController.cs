using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskVardan.Domain;
using TaskVardan.Domain.Models;

namespace TaskVardan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto request)
        {
            var result = await _userService.Login(request);

            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegistrationDto request)
        {
            var result = await _userService.Register(request);

            return Ok(result);
        }
    }
}
