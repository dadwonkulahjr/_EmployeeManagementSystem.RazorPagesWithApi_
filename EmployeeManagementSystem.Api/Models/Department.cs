using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Required, Column(name: "Department Name", TypeName = "nvarchar(50)")]
        [Display(Name = "Department")]
        public string DepartmentName { get; set; }
    }
}
