﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Payroll_System_DAL;

#nullable disable

namespace Payroll_System_DAL.Migrations
{
    [DbContext(typeof(PayrollSystemDbContext))]
    [Migration("20240519102233_Migration1")]
    partial class Migration1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Payroll_System_DAL.Entities.Deduction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("GovContribution")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Loan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SalaryID")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalDeduction")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("SalaryID");

                    b.ToTable("Deductions");
                });

            modelBuilder.Entity("Payroll_System_DAL.Entities.Division", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DivisionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Divisions");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "SYSTEM",
                            CreatedOn = new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3966),
                            DivisionName = "HIGHEST",
                            IsActive = true
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "SYSTEM",
                            CreatedOn = new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3969),
                            DivisionName = "MID",
                            IsActive = true
                        },
                        new
                        {
                            ID = 3,
                            CreatedBy = "SYSTEM",
                            CreatedOn = new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3971),
                            DivisionName = "LOWEST",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("Payroll_System_DAL.Entities.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("DivisionID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionID")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("DivisionID");

                    b.HasIndex("PositionID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Payroll_System_DAL.Entities.Position", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "SYSTEM",
                            CreatedOn = new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3729),
                            IsActive = true,
                            PositionName = "CEO"
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "SYSTEM",
                            CreatedOn = new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3742),
                            IsActive = true,
                            PositionName = "SALES MANAGER"
                        },
                        new
                        {
                            ID = 3,
                            CreatedBy = "SYSTEM",
                            CreatedOn = new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3744),
                            IsActive = true,
                            PositionName = "SALES ASSISTANT"
                        },
                        new
                        {
                            ID = 4,
                            CreatedBy = "SYSTEM",
                            CreatedOn = new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3745),
                            IsActive = true,
                            PositionName = "HR MANAGER"
                        },
                        new
                        {
                            ID = 5,
                            CreatedBy = "SYSTEM",
                            CreatedOn = new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3747),
                            IsActive = true,
                            PositionName = "HR ASSISTANT"
                        },
                        new
                        {
                            ID = 6,
                            CreatedBy = "SYSTEM",
                            CreatedOn = new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3748),
                            IsActive = true,
                            PositionName = "PROGRAMMER III"
                        },
                        new
                        {
                            ID = 7,
                            CreatedBy = "SYSTEM",
                            CreatedOn = new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3750),
                            IsActive = true,
                            PositionName = "PROGRAMMER II"
                        },
                        new
                        {
                            ID = 8,
                            CreatedBy = "SYSTEM",
                            CreatedOn = new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3751),
                            IsActive = true,
                            PositionName = "PROGRAMMER I"
                        },
                        new
                        {
                            ID = 9,
                            CreatedBy = "SYSTEM",
                            CreatedOn = new DateTime(2024, 5, 19, 18, 22, 32, 711, DateTimeKind.Local).AddTicks(3752),
                            IsActive = true,
                            PositionName = "JANITOR"
                        });
                });

            modelBuilder.Entity("Payroll_System_DAL.Entities.Salary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("MonthlySalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SemiMonthlySalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("Payroll_System_DAL.Entities.Deduction", b =>
                {
                    b.HasOne("Payroll_System_DAL.Entities.Salary", "Salary")
                        .WithMany()
                        .HasForeignKey("SalaryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salary");
                });

            modelBuilder.Entity("Payroll_System_DAL.Entities.Employee", b =>
                {
                    b.HasOne("Payroll_System_DAL.Entities.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Payroll_System_DAL.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Division");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Payroll_System_DAL.Entities.Salary", b =>
                {
                    b.HasOne("Payroll_System_DAL.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
