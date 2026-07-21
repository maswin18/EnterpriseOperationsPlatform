using Microsoft.AspNetCore.Mvc;
using EOP.Api.Models;
using EOP.Api.Services;

namespace EOP.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetEmployees()
    {
        var employees = await _employeeService.GetAllEmployeesAsync();

        return Ok(employees);
    }

    [HttpPost]
    public async Task<IActionResult> CreateEmployee(Employee employee)
    {
        var createdEmployee = await _employeeService.CreateEmployeeAsync(employee);

        return Ok(createdEmployee);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmployeeById(int id)
    {
        var employee = await _employeeService.GetEmployeeByIdAsync(id);

        if (employee == null)
        {
            return NotFound();
        }

        return Ok(employee);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmployee(int id, Employee updatedEmployee)
    {
        if (id != updatedEmployee.Id)
        {
            return BadRequest();
        }

        var employee = await _employeeService.UpdateEmployeeAsync(id, updatedEmployee);

        if (employee == null)
        {
            return NotFound();
        }

        return Ok(employee);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        var deleted = await _employeeService.DeleteEmployeeAsync(id);

        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}
