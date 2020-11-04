using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.UI.Pages.MockData
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public void OnGet()
        {
           Employees = MockDataForTestPurpose();
         
        }


        private IEnumerable<Employee> MockDataForTestPurpose()
        {
            List<Employee> listOfMockEmployeeData = new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = 101,
                    FirstName = "David",
                    LastName = "Smith",
                    Gender = Gender.Male,
                    Salary = 5000,
                    DateOfBirth = new System.DateTime(1980, 10, 02),
                    DepartmentId = 1,
                    Email = "david@iamtuseTheProgrammer.com",
                    PhotoPath = "/images/david.png",
                    SkillId = 1
                },
                new Employee()
                {
                    EmployeeId = 102,
                    FirstName = "Mary",
                    LastName = "Thomas",
                    Gender = Gender.Female,
                    Salary = 7000,
                    DateOfBirth = new System.DateTime(1980, 01, 11),
                    DepartmentId = 2,
                    Email = "mary@iamtuseTheProgrammer.com",
                    PhotoPath = "/images/sara.png",
                    SkillId = 2
                },
                new Employee()
                {
                    EmployeeId = 103,
                    FirstName = "Prince",
                    LastName = "Johnson",
                    Gender = Gender.Male,
                    Salary = 1500,
                    DateOfBirth = new System.DateTime(1990, 08, 10),
                    DepartmentId = 1,
                    Email = "prince@iamtuseTheProgrammer.com",
                    PhotoPath = "/images/car.jpg",
                    SkillId = 3
                },
                new Employee()
                {
                    EmployeeId = 104,
                    FirstName = "Freya",
                    LastName = "Cooper",
                    Gender = Gender.Female,
                    Salary = 12000,
                    DateOfBirth = new System.DateTime(1993, 11, 10),
                    DepartmentId = 1,
                    Email = "freya@iamtuseTheProgrammer.com",
                    PhotoPath = "/images/freya.png",
                    SkillId = 4
                }
            };
            return listOfMockEmployeeData.ToList();
        }
    }
}
