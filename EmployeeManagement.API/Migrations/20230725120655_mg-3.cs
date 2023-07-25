using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class mg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employees");

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBrith", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { new Guid("432153b1-10bf-472e-96a2-829eaeb25050"), new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "sara@pragimtech.com", "Sara", 1, "Longway", "images/sara.png" },
                    { new Guid("4c533e47-19f0-4d73-83c1-1907bbdefd4e"), new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Sam@pragimtech.com", "Sam", 0, "Galloway", "images/sam.jpg" },
                    { new Guid("6c14f736-1781-4743-afd4-a74369b52f33"), new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "mary@pragimtech.com", "Mary", 1, "Smith", "images/mary.png" },
                    { new Guid("97b0e1c0-256d-472f-85cc-2671a77bba2c"), new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "David@pragimtech.com", "John", 0, "Hastings", "images/john.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

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

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBrith", "DepartmentId", "Email", "EmployeeId", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { new Guid("432153b1-10bf-472e-96a2-829eaeb25050"), new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "sara@pragimtech.com", 0, "Sara", 1, "Longway", "images/sara.png" },
                    { new Guid("4c533e47-19f0-4d73-83c1-1907bbdefd4e"), new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Sam@pragimtech.com", 0, "Sam", 0, "Galloway", "images/sam.jpg" },
                    { new Guid("6c14f736-1781-4743-afd4-a74369b52f33"), new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "mary@pragimtech.com", 0, "Mary", 1, "Smith", "images/mary.png" },
                    { new Guid("97b0e1c0-256d-472f-85cc-2671a77bba2c"), new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "David@pragimtech.com", 0, "John", 0, "Hastings", "images/john.png" }
                });
        }
    }
}
