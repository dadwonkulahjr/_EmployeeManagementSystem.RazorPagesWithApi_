using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagementSystem.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(name: "Department Name", type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    PhotoPath = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(name: "Skill Name", type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "Department Name" },
                values: new object[,]
                {
                    { 1, "Information Technology" },
                    { 2, "Human Resource" },
                    { 3, "Payroll" },
                    { 4, "Management" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath", "Salary", "SkillId" },
                values: new object[,]
                {
                    { 101, new DateTime(1980, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "david@iamtuseTheProgrammer.com", "David", 1, "Smith", "/images/david.png", 5000m, 1 },
                    { 102, new DateTime(1980, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "mary@iamtuseTheProgrammer.com", "Mary", 2, "Thomas", "/images/sara.png", 7000m, 2 },
                    { 103, new DateTime(1990, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "prince@iamtuseTheProgrammer.com", "Prince", 1, "Johnson", "/images/car.jpg", 1500m, 3 },
                    { 104, new DateTime(1993, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "freya@iamtuseTheProgrammer.com", "Freya", 2, "Cooper", "/images/freya.png", 12000m, 4 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "Skill Name" },
                values: new object[,]
                {
                    { 1, "Developer" },
                    { 2, "Finance Officer" },
                    { 3, "Java Developer" },
                    { 4, "PHP Developer" },
                    { 5, "Chief Financial Officer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
