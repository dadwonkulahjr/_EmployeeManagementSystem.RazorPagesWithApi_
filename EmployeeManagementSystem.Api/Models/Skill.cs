using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EmployeeManagementSystem.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        [Required, Column(name:"Skill Name",TypeName = "nvarchar(50)")]
        [Display(Name = "Skill")]
        public string SkillName { get; set; }
    }
}
