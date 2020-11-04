using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(config =>
            {
                config.HasData(
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
                    );
            });
            modelBuilder.Entity<Department>(config =>
            {
                config.HasData(
                    new Department()
                    {
                        DepartmentId = 1,
                        DepartmentName = "Information Technology"
                    },
                    new Department()
                    {
                        DepartmentId = 2,
                        DepartmentName = "Human Resource"
                    },
                    new Department()
                    {
                        DepartmentId = 3,
                        DepartmentName = "Payroll"
                    },
                    new Department()
                    {
                        DepartmentId = 4,
                        DepartmentName = "Management"
                    }
                    );
            });
            modelBuilder.Entity<Skill>(config =>
            {
                config.HasData(
                    new Skill()
                    {
                        SkillId = 1,
                        SkillName = "Developer"
                    },
                    new Skill()
                    {
                        SkillId = 2,
                        SkillName = "Finance Officer"
                    },
                    new Skill()
                    {
                        SkillId = 3,
                        SkillName = "Java Developer"
                    },
                    new Skill()
                    {
                        SkillId = 4,
                        SkillName = "PHP Developer"
                    },
                    new Skill()
                    {
                        SkillId = 5,
                        SkillName = "Chief Financial Officer"
                    }
                    );
            });

        }
    }
}
