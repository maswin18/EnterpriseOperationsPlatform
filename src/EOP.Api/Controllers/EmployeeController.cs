using Microsoft.AspNetCore.Mvc;
using EOP.Api.Models;

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
            new Employee
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
