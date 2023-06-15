using AN_CRM.Controllers.Resources;
using AN_CRM.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AN_CRM.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        [AllowAnonymous]
        [HttpPost]
        [ActionName("AddUpdateUser")]
        public async Task<IActionResult> AddUpdateUser([FromBody] AddUpdateUserResource resource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = usersRepository.AddUpdateUser(resource);
            return Ok(user);

        }
        [AllowAnonymous]
        [HttpPost]
        [ActionName("Login")]
        public async Task<IActionResult> Login(LoginResource resource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = usersRepository.Login(resource);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("balance")]
        public async Task<IActionResult> GetBalance(int userId)
        {
            var result =usersRepository.GetBalance(userId);
            return Ok(result);
        }
    }
}
