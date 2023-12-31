﻿using EmployeeManagement.Models.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            try
            {

                return await httpClient.GetJsonAsync<Employee[]>("api/employees");
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Employee>();
            }
        }

        public async Task<Employee> GetEmployee(Guid id)
        {
            return await httpClient.GetJsonAsync<Employee>($"api/employees/{id}");
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            return await httpClient.PutJsonAsync<Employee>($"api/employees/{employee.EmployeeId}", employee);
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            return await httpClient.PostJsonAsync<Employee>("api/employees", employee);
        }

        public async Task DeleteEmployee(Guid employeeId)
        {
            await httpClient.DeleteAsync($"api/employees/{employeeId}");
        }

    }
}
