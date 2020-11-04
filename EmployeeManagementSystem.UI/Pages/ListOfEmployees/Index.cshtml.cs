using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.UI.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagementSystem.UI.Pages.ListOfEmployees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepo _employeeRepo;
        public IEnumerable<Employee> Employees { get; set; }
        public IndexModel(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        public async Task OnGet()
        {
            Employees = await _employeeRepo.GetAllEmployees();
        }
    }
}
