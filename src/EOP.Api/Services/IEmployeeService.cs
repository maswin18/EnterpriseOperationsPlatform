using EOP.Api.Models;

namespace EOP.Api.Services;

public interface IEmployeeService
{
    Task<List<Employee>> GetAllEmployeesAsync();

    Task<Employee?> GetEmployeeByIdAsync(int id);

    Task<Employee> CreateEmployeeAsync(Employee employee);

    Task<Employee?> UpdateEmployeeAsync(int id, Employee updatedEmployee);

    Task<bool> DeleteEmployeeAsync(int id);
}