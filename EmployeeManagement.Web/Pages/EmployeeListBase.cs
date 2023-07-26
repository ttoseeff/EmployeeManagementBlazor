using EmployeeManagement.Models.Models;
using EmployeeManagement.Web.Services;
using EmployeeManagement.Web.Shared;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService employeeService { get; set; }

        protected bool ShowFooter { get; set; } = true;
        protected int TotalSelectedEmployees { get; set; } = 0;
        public IEnumerable<Employee> Employees { get; set; } = Enumerable.Empty<Employee>();

        protected ConfirmationBase DeleteConfirmation { get; set; }

        protected DisplayEmployeeBase DisplayEmployeeRef { get; set; }
        protected Guid CurrentEmployeeId { get; private set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await employeeService.GetEmployees()).ToList();
        }

        protected async Task OnDeleteEmployee(Guid employeeId)
        {
            CurrentEmployeeId = employeeId;
            //await employeeService.DeleteEmployee(employeeId);
            //Employees = (await employeeService.GetEmployees()).ToList();
        }

        protected void GetTotalSelectedEmployees(bool IsSelected)
        {
            if (IsSelected)
            {
                TotalSelectedEmployees++;
            }
            else
            {
                TotalSelectedEmployees--;
            }
        }

        protected async Task DeleteEmployee(bool isDeleted)
        {
            if (isDeleted)
            {
                await DisplayEmployeeRef.DeleteEmployee(CurrentEmployeeId);
                Employees = (await employeeService.GetEmployees()).ToList();
            }
        }

        //private void LoadEmployees()
        //{
        //    System.Threading.Thread.Sleep(3000);
        //    Employee e1 = new Employee
        //    {
        //        EmployeeId = 1,
        //        FirstName = "John",
        //        LastName = "Hastings",
        //        Email = "David@pragimtech.com",
        //        DateOfBrith = new DateTime(1980, 10, 5),
        //        Gender = Gender.Male,
        //        //Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
        //        DepartmentId = 1,
        //        PhotoPath = "images/john.png"
        //    };

        //    Employee e2 = new Employee
        //    {
        //        EmployeeId = 2,
        //        FirstName = "Sam",
        //        LastName = "Galloway",
        //        Email = "Sam@pragimtech.com",
        //        DateOfBrith = new DateTime(1981, 12, 22),
        //        Gender = Gender.Male,
        //        //Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
        //        DepartmentId = 2,
        //        PhotoPath = "images/sam.jpg"
        //    };

        //    Employee e3 = new Employee
        //    {
        //        EmployeeId = 3,
        //        FirstName = "Mary",
        //        LastName = "Smith",
        //        Email = "mary@pragimtech.com",
        //        DateOfBrith = new DateTime(1979, 11, 11),
        //        Gender = Gender.Female,
        //        //Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
        //        DepartmentId = 3,
        //        PhotoPath = "images/mary.png"
        //    };

        //    Employee e4 = new Employee
        //    {
        //        EmployeeId = 3,
        //        FirstName = "Sara",
        //        LastName = "Longway",
        //        Email = "sara@pragimtech.com",
        //        DateOfBrith = new DateTime(1982, 9, 23),
        //        Gender = Gender.Female,
        //        //Department = new Department { DepartmentId = 3, DepartmentName = "Payroll" },
        //        DepartmentId = 4,
        //        PhotoPath = "images/sara.png"
        //    };

        //    Employees = new List<Employee> { e1, e2, e3, e4 };
        //}

    }
}
