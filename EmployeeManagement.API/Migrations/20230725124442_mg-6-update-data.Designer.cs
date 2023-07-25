﻿// <auto-generated />
using System;
using EmployeeManagement.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagement.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230725124442_mg-6-update-data")]
    partial class mg6updatedata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagement.Models.Models.Department", b =>
                {
                    b.Property<Guid>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = new Guid("db26d26e-a2b7-4409-b47a-a96b7aa5543f"),
                            DepartmentName = "IT"
                        },
                        new
                        {
                            DepartmentId = new Guid("fac7a1c6-a723-4431-80fc-56163417042e"),
                            DepartmentName = "HR"
                        },
                        new
                        {
                            DepartmentId = new Guid("def2c50e-ffea-4484-9441-292e8411acf7"),
                            DepartmentName = "Payroll"
                        },
                        new
                        {
                            DepartmentId = new Guid("582ec231-afbc-41c1-bdb8-c033fbb29a0b"),
                            DepartmentName = "Admin"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Models.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBrith")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = new Guid("17b0e1c0-256d-472f-85cc-2671a77bba2c"),
                            DateOfBrith = new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("db26d26e-a2b7-4409-b47a-a96b7aa5543f"),
                            Email = "David@pragimtech.com",
                            FirstName = "John",
                            Gender = 0,
                            LastName = "Hastings",
                            PhotoPath = "images/john.png"
                        },
                        new
                        {
                            EmployeeId = new Guid("2c533e47-19f0-4d73-83c1-1907bbdefd4e"),
                            DateOfBrith = new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("fac7a1c6-a723-4431-80fc-56163417042e"),
                            Email = "Sam@pragimtech.com",
                            FirstName = "Sam",
                            Gender = 0,
                            LastName = "Galloway",
                            PhotoPath = "images/sam.jpg"
                        },
                        new
                        {
                            EmployeeId = new Guid("3c14f736-1781-4743-afd4-a74369b52f33"),
                            DateOfBrith = new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("def2c50e-ffea-4484-9441-292e8411acf7"),
                            Email = "mary@pragimtech.com",
                            FirstName = "Mary",
                            Gender = 1,
                            LastName = "Smith",
                            PhotoPath = "images/mary.png"
                        },
                        new
                        {
                            EmployeeId = new Guid("532153b1-10bf-472e-96a2-829eaeb25050"),
                            DateOfBrith = new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("582ec231-afbc-41c1-bdb8-c033fbb29a0b"),
                            Email = "sara@pragimtech.com",
                            FirstName = "Sara",
                            Gender = 1,
                            LastName = "Longway",
                            PhotoPath = "images/sara.png"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
