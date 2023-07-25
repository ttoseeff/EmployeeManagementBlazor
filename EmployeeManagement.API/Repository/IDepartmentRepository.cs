using EmployeeManagement.Models.Models;

namespace EmployeeManagement.API.Repository
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(Guid departmentId);
    }
}
