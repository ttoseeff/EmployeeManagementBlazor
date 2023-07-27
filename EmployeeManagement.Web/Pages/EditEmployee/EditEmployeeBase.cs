using AutoMapper;
using EmployeeManagement.Models.Models;
using EmployeeManagement.Web.Models;
using EmployeeManagement.Web.Services;
using EmployeeManagement.Web.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net;

namespace EmployeeManagement.Web.Pages.EditEmployee
{
    public class EditEmployeeBase : ComponentBase
    {
        [CascadingParameter]
        public Task<AuthenticationState> authenticationStateTask { get; set; }
        private Employee Employee { get; set; } = new Employee();
        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        [Inject]
        public IMapper Mapper { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected ConfirmationBase deleteConfiramtion { get; set; }

        [Parameter]
        public string Id { get; set; }

        public Guid DepartmentId { get; set; }

        protected List<Department> Departments { get; set; }

        protected string PageHeader { get; set; } = "Create Employee";

        protected async override Task OnInitializedAsync()
        {
            var authenticationState = await authenticationStateTask;
            if (authenticationState.User.Identity != null && !authenticationState.User.Identity.IsAuthenticated)
            {
                string returnUrl = WebUtility.UrlEncode($"/editemployee/{Id}");
                NavigationManager.NavigateTo($"/identity/account/login?returnUrl={returnUrl}");
            }

            Guid.TryParse(Id, out Guid EmployeeId);
            if (EmployeeId != Guid.Empty)
            {
                PageHeader = "Edit Employee";
                Employee = await EmployeeService.GetEmployee(Guid.Parse(Id));
            }
            else
            {
                Employee = new Employee
                {
                    DepartmentId = new Guid("FAC7A1C6-A723-4431-80FC-56163417042E"),
                    DateOfBrith = DateTime.Now,
                    PhotoPath = "images/nophoto.jpg"
                };
            }
            Departments = await DepartmentService.GetDepartments();
            DepartmentId = Employee.DepartmentId;
            Mapper.Map(Employee, EditEmployeeModel);
        }

        protected async Task HandleValidSubmit()
        {
            Mapper.Map(EditEmployeeModel, Employee);
            Employee.DepartmentId = DepartmentId;
            Employee result = null;

            if (Employee.EmployeeId != Guid.Empty)
            {
                result = await EmployeeService.UpdateEmployee(Employee);
            }
            else
            {
                //Employee.Department = await DepartmentService.GetDepartmentById(DepartmentId);
                result = await EmployeeService.CreateEmployee(Employee);
            }

            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }

        protected void Delete_Click()
        {
            deleteConfiramtion.Show();
        }

        protected async Task DeleteEmployee(bool isDeleted)
        {
            if (isDeleted)
            {
                await EmployeeService.DeleteEmployee(Employee.EmployeeId);
                NavigationManager.NavigateTo("/");
            }
        }

    }
}
