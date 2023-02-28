using AutoMapper;
using GreenCloud.Store.Application.Dtos;
using GreenCloud.Store.Application.Interfaces;
using GreenCloud.Store.Entity;
using GreenCloud.Store.Repository.Interfaces;

namespace GreenCloud.Store.Application.Implementations
{
    public class EmployeesApplication : IEmployeesApplication
    {
        private readonly IEmployeesRepository employeesRepository;
        private readonly IMapper mapper;

        public EmployeesApplication(IEmployeesRepository employeesRepository, IMapper mapper)
        {
            this.employeesRepository = employeesRepository;
            this.mapper = mapper;
        }

        public async Task<List<EmployeeForListDto>> GetEmployees()
        {
            var employees = await employeesRepository.GetEmployees();

            var employeesDto = mapper.Map<List<EmployeeForListDto>>(employees);
            return employeesDto;
        }
        public async Task<EmployeeDetailDto> GetEmployee(int id)
        {
            var employee = await employeesRepository.GetEmployee(id);
            var employeeDto = mapper.Map<EmployeeDetailDto>(employee);
            return employeeDto;
        }

        public async Task InsetEmployee(EmployeeForCreateDto employeeForCreateDto)
        {
            var employeeEntity = mapper.Map<Employee>(employeeForCreateDto);
            await employeesRepository.InsertEmployee(employeeEntity);
        }
    }
}
