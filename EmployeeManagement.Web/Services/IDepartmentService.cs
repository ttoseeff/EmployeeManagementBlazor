using EmployeeManagement.Models.Models;

namespace EmployeeManagement.Web.Services
{
    public interface IDepartmentService
    {
        Task<Department> GetDepartmentById(Guid id);
        Task<List<Department>> GetDepartments();
    }
}