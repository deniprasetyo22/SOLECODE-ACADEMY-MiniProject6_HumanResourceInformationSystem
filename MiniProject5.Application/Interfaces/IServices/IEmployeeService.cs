using MiniProject5.Application.DTOs;
using MiniProject5.Persistence.Models;
using MiniProject6.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject6.Application.Interfaces.IServices
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployeesNoPagesAsync();
        Task<object> GetAllEmployeesAsync(QueryObject query);
        Task<Employee> GetEmployeeByIdAsync(int empId);
        Task<Employee> AddEmployeeAsync(Employee employee);
        Task<bool> UpdateEmployeeAsync(int empId, EmployeeDto employeeDto);
        Task DeactivateEmployeeAsync(int empId, string reason);
        Task ActivateEmployeeAsync(int empId);
        Task DeleteEmployeeAsync(int empId);
        Task<IEnumerable<Employee>> SearchEmployee(SearchDto search, paginationDto pagination);
        Task<IEnumerable<Employee>> GetSupervisedEmployeesAsync(int supervisorId);
        Task<EmployeeDto> GetOwnProfile();
        Task<bool> UpdateOwnProfile(EmployeeDto employeeDto);
    }
}
