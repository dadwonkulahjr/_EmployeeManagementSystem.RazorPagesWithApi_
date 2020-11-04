using EmployeeManagementSystem.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.UI.Services
{
    public interface IEmployeeRepo
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployee(int id);
    }
}
