using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAvalonia1.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private User user = new User()
        {
            Id = 1,
            Name = "ToszekWeselak",
            Email = "00oookiocz@gmail.com",
            Password = "",
            Role = "Admin",
        };
        private User empty = new User();
        [HttpGet("")]
        [HttpGet("GetUser")]
        public User GetUser([FromQuery] string? name = null)
        {
            if (!string.IsNullOrEmpty(name) && name.Equals(user.Name, StringComparison.OrdinalIgnoreCase))
            {
                return user;
            }
            else if (string.IsNullOrEmpty(name))
            {
                return empty;
            }
            else
            {
                return empty;
            }
        }
    }
}
