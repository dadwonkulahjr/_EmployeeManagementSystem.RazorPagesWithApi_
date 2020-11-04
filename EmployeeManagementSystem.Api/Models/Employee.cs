using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required, Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }
        [Required, Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required, Column(TypeName = "decimal(18,0)")]
        public decimal? Salary { get; set; }
        public string PhotoPath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public int SkillId { get; set; }
        public Department Department { get; set; }
        public Skill Skill { get; set; }
    }
}
