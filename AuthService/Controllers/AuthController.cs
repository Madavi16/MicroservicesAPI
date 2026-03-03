using AuthService.Data;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {

        private readonly AuthDbContext _context;

        public AuthController(AuthDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login(Models.UserLogin userLogin)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == userLogin.Username && u.Password == userLogin.Password);
            if (user == null)
                return Unauthorized("Invalid credentials!");
           
            return Ok("Login successful!");
        }
    }
}
