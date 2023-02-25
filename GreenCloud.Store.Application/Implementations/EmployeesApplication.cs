using GreenCloud.Store.Application.Interfaces;
using GreenCloud.Store.Entity;
using GreenCloud.Store.Repository.Interfaces;

namespace GreenCloud.Store.Application.Implementations
{
    public class EmployeesApplication : IEmployeesApplication
    {
        private readonly IEmployeesRepository employeesRepository;

        public EmployeesApplication(IEmployeesRepository employeesRepository)
        {
            this.employeesRepository = employeesRepository;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var employees = await employeesRepository.GetEmployees();
            return employees;
        }
        public async Task<Employee> GetEmployee(int id)
        {
            var employee = await employeesRepository.GetEmployee(id);
            return employee;
        }

    }
}
