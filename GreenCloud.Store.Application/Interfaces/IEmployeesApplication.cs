using GreenCloud.Store.Application.Dtos;

namespace GreenCloud.Store.Application.Interfaces
{
    public interface IEmployeesApplication
    {
        Task<List<EmployeeForListDto>> GetEmployees();
        Task<EmployeeDetailDto> GetEmployee(int id);

        Task InsetEmployee(EmployeeForCreateDto employeeForCreateDto);
    }
}
