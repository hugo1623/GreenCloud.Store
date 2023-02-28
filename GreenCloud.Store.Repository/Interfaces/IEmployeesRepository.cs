using GreenCloud.Store.Entity;

namespace GreenCloud.Store.Repository.Interfaces
{
    public interface IEmployeesRepository
    {
      Task<List<Employee>> GetEmployees();

      Task<Employee> GetEmployee(int id);

        Task InsertEmployee(Employee employee);
    }
}
