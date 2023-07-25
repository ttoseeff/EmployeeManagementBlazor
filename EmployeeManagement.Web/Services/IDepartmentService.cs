using EmployeeManagement.Models.Models;

namespace EmployeeManagement.Web.Services
{
    public interface IDepartmentService
    {
        Task<Department> GetDepartmentById(int id);
        Task<List<Department>> GetDepartments();
    }
}