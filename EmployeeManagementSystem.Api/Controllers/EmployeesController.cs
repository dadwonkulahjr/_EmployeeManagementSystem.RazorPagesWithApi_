using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            try
            {
                return base.Ok(await _employeeRepository.GetAllEmployees());
            }
            catch (System.Exception)
            {

                return base.StatusCode(StatusCodes.Status500InternalServerError,
                    "There were errors retrieving the list of employees," +
                    "Please contact your admin!");
            }
        }
        [HttpGet(template: "{id:int}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(int id)
        {
            try
            {
                var employeeFound = await _employeeRepository.GetEmployee(id);
                if(employeeFound == null)
                {
                    return base.NotFound($"The employee with Id = {id} not found.");
                }
                return base.Ok(employeeFound);
            }
            catch (System.Exception)
            {

                return base.StatusCode(StatusCodes.Status500InternalServerError,
                    "There were errors retrieving the specific employee details," +
                    "Please contact your admin!");
            }
        }
    }
}
