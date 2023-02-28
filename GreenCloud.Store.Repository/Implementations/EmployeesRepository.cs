using GreenCloud.Store.Entity;
using GreenCloud.Store.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GreenCloud.Store.Repository.Implementations
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly StoreContext context;

        public EmployeesRepository(StoreContext context)
        {
            this.context = context;
        }

        public async Task< List<Employee>> GetEmployees()
        {
            var employees = await context.Employees.ToListAsync();
            return employees;
        }
        public async Task<Employee> GetEmployee(int id)
        {
            var employee = await context.Employees.FirstOrDefaultAsync(x => x.Id == id);
            return employee;
        }

        public async Task InsertEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            await context.SaveChangesAsync();
        }
    }
}
