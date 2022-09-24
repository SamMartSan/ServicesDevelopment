using EmployeeApp.Application.Interfaces;
using EmployeeApp.Domain.Entities;
using EmployeeApp.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EmployeeApp.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> AddAsync(Employee entity)
        {
            return await _employeeRepository.AddAsync(entity);
        }

        public async Task<IEnumerable<Employee>> FindAsync(Expression<Func<Employee, bool>> predicate)
        {
            return await _employeeRepository.FindAsync(predicate);
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _employeeRepository.GetAllAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);

            // Validte If Exist
            return employee;
        }

        public async Task RemoveAsync(int id)
        {
            var person = await _employeeRepository.GetByIdAsync(id);
            await _employeeRepository.RemoveAsync(person);
        }

        public async Task UpdateAsync(int id, Employee entity)
        {
            // Validate if Exist
            await _employeeRepository.UpdateAsync(entity);
        }
    }
}