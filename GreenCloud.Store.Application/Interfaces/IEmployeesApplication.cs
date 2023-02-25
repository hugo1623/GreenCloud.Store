using GreenCloud.Store.Entity;

namespace GreenCloud.Store.Application.Interfaces
{
    public interface IEmployeesApplication
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
    }
}
