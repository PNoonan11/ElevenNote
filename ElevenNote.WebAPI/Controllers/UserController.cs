using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNote.Models.User;
using ElevenNote.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ElevenNote.Services.Token;
using ElevenNote.Models.Tokens;

namespace ElevenNote.WebAPI.Controllers
{
    [ApiController, Route("api/[controller]")]

    public class UserController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IUserService _userService;
        public UserController(IUserService userService, ITokenService tokenService)
        {
            _userService = userService;
            _tokenService = tokenService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegister model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var registerResult = await _userService.RegisterUserAsync(model);
            if (registerResult)
            {
                return Ok("User was registered.");
            }
            return BadRequest("User could not be registered.");
        }

        [Authorize, HttpGet("{userId:int}")]

        public async Task<IActionResult> GetById([FromRoute] int userId)
        {
            var userDetail = await _userService.GetUserByIdAsync(userId);
            if (userDetail is null)
            {
                return NotFound();
            }
            return Ok(userDetail);
        }

        [HttpPost("~/api/Token")]
        public async Task<IActionResult> Token([FromBody] TokenRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
        }






    }
}
