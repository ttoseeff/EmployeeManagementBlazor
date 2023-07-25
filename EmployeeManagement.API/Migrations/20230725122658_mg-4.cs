using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class mg4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");
            migrationBuilder.DropPrimaryKey(
               name: "PK_Departments",
               table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Departments"

                );

            migrationBuilder.AlterColumn<Guid>(
                name: "DepartmentId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "Departments",
                type: "uniqueidentifier",
                nullable: false);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { new Guid("582ec231-afbc-41c1-bdb8-c033fbb29a0b"), "Admin" },
                    { new Guid("db26d26e-a2b7-4409-b47a-a96b7aa5543f"), "IT" },
                    { new Guid("def2c50e-ffea-4484-9441-292e8411acf7"), "Payroll" },
                    { new Guid("fac7a1c6-a723-4431-80fc-56163417042e"), "HR" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("432153b1-10bf-472e-96a2-829eaeb25050"),
                column: "DepartmentId",
                value: new Guid("582ec231-afbc-41c1-bdb8-c033fbb29a0b"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("4c533e47-19f0-4d73-83c1-1907bbdefd4e"),
                column: "DepartmentId",
                value: new Guid("fac7a1c6-a723-4431-80fc-56163417042e"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("6c14f736-1781-4743-afd4-a74369b52f33"),
                column: "DepartmentId",
                value: new Guid("def2c50e-ffea-4484-9441-292e8411acf7"));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("97b0e1c0-256d-472f-85cc-2671a77bba2c"),
                column: "DepartmentId",
                value: new Guid("db26d26e-a2b7-4409-b47a-a96b7aa5543f"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("582ec231-afbc-41c1-bdb8-c033fbb29a0b"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("db26d26e-a2b7-4409-b47a-a96b7aa5543f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("def2c50e-ffea-4484-9441-292e8411acf7"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: new Guid("fac7a1c6-a723-4431-80fc-56163417042e"));

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Departments",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Payroll" },
                    { 4, "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("432153b1-10bf-472e-96a2-829eaeb25050"),
                column: "DepartmentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("4c533e47-19f0-4d73-83c1-1907bbdefd4e"),
                column: "DepartmentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("6c14f736-1781-4743-afd4-a74369b52f33"),
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("97b0e1c0-256d-472f-85cc-2671a77bba2c"),
                column: "DepartmentId",
                value: 1);
        }
    }
}
