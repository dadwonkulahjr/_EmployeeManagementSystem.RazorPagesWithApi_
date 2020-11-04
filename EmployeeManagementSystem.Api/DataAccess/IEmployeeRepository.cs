using EmployeeManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Services
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployee(int id);
    }
}
