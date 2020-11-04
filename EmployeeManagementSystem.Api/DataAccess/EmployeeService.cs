using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeService : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _appDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _appDbContext.Employees
                .Include(e => e.Department)
                .Include(e => e.Skill)
                .FirstOrDefaultAsync(e => e.EmployeeId == id);
        }
    }
}
