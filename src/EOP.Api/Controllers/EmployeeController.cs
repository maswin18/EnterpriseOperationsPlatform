using Microsoft.AspNetCore.Mvc;

namespace EOP.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpGet]
    public IActionResult GetEmployees()
    {
        var employees = new[]
        {
            new
            {
                Id = 100001,
                Name = "Maswin Putra",
                Department = "IT",
                Position = "Software Developer"
            }
        };

        return Ok(employees);
    }
}
