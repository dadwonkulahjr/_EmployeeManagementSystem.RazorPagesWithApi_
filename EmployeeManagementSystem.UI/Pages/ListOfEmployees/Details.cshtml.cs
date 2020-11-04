using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.UI.Pages.ListOfEmployees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepo _employeeRepo;
        public Employee Employee { get; set; }

        public DetailsModel(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        public async Task<IActionResult> OnGet(int id)
        {
            Employee = await _employeeRepo.GetEmployee(id);
            if(Employee == null)
            {
                return NotFound($"The employee with Id = {id} not found.");
            }
            return Page();
        }
    }
}
