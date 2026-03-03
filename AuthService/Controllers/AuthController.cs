using AuthService.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace AuthService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login(UserLogin model)
        {
            if (model.Username == "Mahesh" && model.Password == "6784")
                return Ok("Login successful");

            return Unauthorized();
        }
    }
}
