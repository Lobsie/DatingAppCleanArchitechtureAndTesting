using DatingApp.API.Core.Dtos;
using DatingApp.API.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IAppUserService appUserService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await appUserService.GetAllAsync();

            if (users == null) return NotFound();

            return Ok(users);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await appUserService.GetByIdAsync(id);

            if (user == null) return NotFound();

            return Ok(user);
        }
    }
}
