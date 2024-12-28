using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;

namespace UserManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<User>
            {
                new User { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" },
                new User { FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com" },
                new User { FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com" },
            };

            return Ok(users);
        }
    }
}
