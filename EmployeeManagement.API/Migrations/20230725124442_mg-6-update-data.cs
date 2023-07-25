    using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class mg6updatedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("432153b1-10bf-472e-96a2-829eaeb25050"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("4c533e47-19f0-4d73-83c1-1907bbdefd4e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("6c14f736-1781-4743-afd4-a74369b52f33"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("97b0e1c0-256d-472f-85cc-2671a77bba2c"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBrith", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { new Guid("17b0e1c0-256d-472f-85cc-2671a77bba2c"), new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("db26d26e-a2b7-4409-b47a-a96b7aa5543f"), "David@pragimtech.com", "John", 0, "Hastings", "images/john.png" },
                    { new Guid("2c533e47-19f0-4d73-83c1-1907bbdefd4e"), new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fac7a1c6-a723-4431-80fc-56163417042e"), "Sam@pragimtech.com", "Sam", 0, "Galloway", "images/sam.jpg" },
                    { new Guid("3c14f736-1781-4743-afd4-a74369b52f33"), new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("def2c50e-ffea-4484-9441-292e8411acf7"), "mary@pragimtech.com", "Mary", 1, "Smith", "images/mary.png" },
                    { new Guid("532153b1-10bf-472e-96a2-829eaeb25050"), new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("582ec231-afbc-41c1-bdb8-c033fbb29a0b"), "sara@pragimtech.com", "Sara", 1, "Longway", "images/sara.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("17b0e1c0-256d-472f-85cc-2671a77bba2c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("2c533e47-19f0-4d73-83c1-1907bbdefd4e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("3c14f736-1781-4743-afd4-a74369b52f33"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("532153b1-10bf-472e-96a2-829eaeb25050"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBrith", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { new Guid("432153b1-10bf-472e-96a2-829eaeb25050"), new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("582ec231-afbc-41c1-bdb8-c033fbb29a0b"), "sara@pragimtech.com", "Sara", 1, "Longway", "images/sara.png" },
                    { new Guid("4c533e47-19f0-4d73-83c1-1907bbdefd4e"), new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fac7a1c6-a723-4431-80fc-56163417042e"), "Sam@pragimtech.com", "Sam", 0, "Galloway", "images/sam.jpg" },
                    { new Guid("6c14f736-1781-4743-afd4-a74369b52f33"), new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("def2c50e-ffea-4484-9441-292e8411acf7"), "mary@pragimtech.com", "Mary", 1, "Smith", "images/mary.png" },
                    { new Guid("97b0e1c0-256d-472f-85cc-2671a77bba2c"), new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("db26d26e-a2b7-4409-b47a-a96b7aa5543f"), "David@pragimtech.com", "John", 0, "Hastings", "images/john.png" }
                });
        }
    }
}
