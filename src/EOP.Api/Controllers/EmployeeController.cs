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
        var employees = new List<Employee>
        {
            new Employee
            {
                Id = 100001,
                Name = "Maswin Putra",
                Department = "IT",
                Position = "Software Developer"
            },

            new Employee
            {
                Id = 100002,
                Name = "John Smith",
                Department = "Finance",
                Position = "Manager"
            }
        };

        return Ok(employees);
    }
}
