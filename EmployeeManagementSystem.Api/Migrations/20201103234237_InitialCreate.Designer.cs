﻿// <auto-generated />
using System;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagementSystem.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201103234237_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagementSystem.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnName("Department Name")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "Information Technology"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "Human Resource"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Payroll"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "Management"
                        });
                });

            modelBuilder.Entity("EmployeeManagementSystem.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Salary")
                        .IsRequired()
                        .HasColumnType("decimal(18,0)");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 101,
                            DateOfBirth = new DateTime(1980, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "david@iamtuseTheProgrammer.com",
                            FirstName = "David",
                            Gender = 1,
                            LastName = "Smith",
                            PhotoPath = "/images/david.png",
                            Salary = 5000m,
                            SkillId = 1
                        },
                        new
                        {
                            EmployeeId = 102,
                            DateOfBirth = new DateTime(1980, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            Email = "mary@iamtuseTheProgrammer.com",
                            FirstName = "Mary",
                            Gender = 2,
                            LastName = "Thomas",
                            PhotoPath = "/images/sara.png",
                            Salary = 7000m,
                            SkillId = 2
                        },
                        new
                        {
                            EmployeeId = 103,
                            DateOfBirth = new DateTime(1990, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "prince@iamtuseTheProgrammer.com",
                            FirstName = "Prince",
                            Gender = 1,
                            LastName = "Johnson",
                            PhotoPath = "/images/car.jpg",
                            Salary = 1500m,
                            SkillId = 3
                        },
                        new
                        {
                            EmployeeId = 104,
                            DateOfBirth = new DateTime(1993, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "freya@iamtuseTheProgrammer.com",
                            FirstName = "Freya",
                            Gender = 2,
                            LastName = "Cooper",
                            PhotoPath = "/images/freya.png",
                            Salary = 12000m,
                            SkillId = 4
                        });
                });

            modelBuilder.Entity("EmployeeManagementSystem.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasColumnName("Skill Name")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            SkillId = 1,
                            SkillName = "Developer"
                        },
                        new
                        {
                            SkillId = 2,
                            SkillName = "Finance Officer"
                        },
                        new
                        {
                            SkillId = 3,
                            SkillName = "Java Developer"
                        },
                        new
                        {
                            SkillId = 4,
                            SkillName = "PHP Developer"
                        },
                        new
                        {
                            SkillId = 5,
                            SkillName = "Chief Financial Officer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
