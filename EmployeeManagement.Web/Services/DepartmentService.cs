using EmployeeManagement.Models.Models;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;

namespace EmployeeManagement.Web.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await httpClient.GetJsonAsync<List<Department>>("api/department");
        }

        public async Task<Department> GetDepartmentById(Guid id)
        {
            return await httpClient.GetJsonAsync<Department>($"api/department/{id}");
        }
    }
}
