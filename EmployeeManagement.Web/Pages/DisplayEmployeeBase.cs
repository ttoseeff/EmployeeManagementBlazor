using EmployeeManagement.Models.Models;
using EmployeeManagement.Web.Services;
using EmployeeManagement.Web.Shared;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class DisplayEmployeeBase : ComponentBase
    {
        [Inject]
        public IDepartmentService departmentService { get; set; }
        [Inject]
        public IEmployeeService employeeService { get; set; }

        [Parameter]
        public Employee Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; } = true;

        [Parameter]
        public EventCallback<bool> OnSelectionChanged { get; set; }

        [Parameter]
        public EventCallback<Guid> OnDeleteCallback { get; set; }

        protected bool IsSelected { get; set; }

        protected List<Department> Departments { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Departments = await departmentService.GetDepartments();
        }

        protected async Task OnCheckboxChange(ChangeEventArgs e)
        {
            if (e.Value != null)
            {
                IsSelected = (bool)e.Value;
                await OnSelectionChanged.InvokeAsync(IsSelected);
            }
        }
        [Parameter]
        public ConfirmationBase DeleteConfirmation { get; set; }

        public async Task Handle_Delete(Guid EmployeeId)
        {
            DeleteConfirmation.Show();
            await OnDeleteCallback.InvokeAsync(EmployeeId);
        }

        public async Task DeleteEmployee(Guid EmployeeId)
        {
            await employeeService.DeleteEmployee(EmployeeId);
        }

    }
}
