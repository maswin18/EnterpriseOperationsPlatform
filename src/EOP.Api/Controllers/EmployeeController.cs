using Microsoft.AspNetCore.Mvc;
using EOP.Api.Models;
using EOP.Api.Data;
using EOP.Api.Services;
using Microsoft.EntityFrameworkCore;

namespace EOP.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly EmployeeService _employeeService;

    public EmployeeController(ApplicationDbContext context, EmployeeService employeeService)
    {
        _context = context;
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
        var employee = await _context.Employees.FindAsync(id);

        if (employee == null)
        {
            return NotFound();
        }

        _context.Employees.Remove(employee);

        await _context.SaveChangesAsync();

        return NoContent();
    }
}
