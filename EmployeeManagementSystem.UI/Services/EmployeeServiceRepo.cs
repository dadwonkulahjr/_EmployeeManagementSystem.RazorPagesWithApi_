using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.UI.Services
{
    public class EmployeeServiceRepo : IEmployeeRepo
    {
        private readonly HttpClient _httpClient;

        public EmployeeServiceRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _httpClient.GetJsonAsync<Employee[]>("api/employees");
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await _httpClient.GetJsonAsync<Employee>($"api/employees/{id}");
        }
    }
}
