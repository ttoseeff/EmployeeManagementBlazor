using EmployeeManagement.Models.Models;

namespace EmployeeManagement.API.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(Guid employeeId);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(Guid employeeId);
        Task<Employee> GetEmployeeByEmail(string email);

        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
    }
}
