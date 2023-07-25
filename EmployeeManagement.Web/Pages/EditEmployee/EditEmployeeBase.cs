using AutoMapper;
using EmployeeManagement.Models.Models;
using EmployeeManagement.Web.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages.EditEmployee
{
    public class EditEmployeeBase : ComponentBase
    {
        private Employee Employee { get; set; } = new Employee();
        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        [Inject]
        public IMapper Mapper { get; set; }

        [Parameter]
        public string Id { get; set; }

        public Guid DepartmentId { get; set; }

        protected List<Department> Departments { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(Guid.Parse(Id));
            Departments = await DepartmentService.GetDepartments();
            DepartmentId = Employee.DepartmentId;
            Mapper.Map(Employee, EditEmployeeModel);
        }

        protected void HandleValidSubmit()
        {

        }
    }
}
