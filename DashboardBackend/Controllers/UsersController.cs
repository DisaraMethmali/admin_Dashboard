using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = new[]
        {
            new { FirstName = "John", LastName = "Doe", Address = "123 Elm Street", Mobile = "555-1234", Email = "john.doe@example.com", Department = "Sales", Designation = "Manager", Updated = "2024-05-08 1:45PM", Number = 1 },
            // Add more users here
        };
        return Ok(users);
    }
}
