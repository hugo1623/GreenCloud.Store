using GreenCloud.Store.Application.Dtos;
using GreenCloud.Store.Application.Interfaces;
using GreenCloud.Store.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GreenCloud.Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesApplication employeesApplication;

        public EmployeesController(IEmployeesApplication employeesApplication)
        {
            this.employeesApplication = employeesApplication;
        }
        [HttpGet]
        public async Task<ActionResult<List<EmployeeForListDto>>> GetAll()
        {
            var employee = await employeesApplication.GetEmployees();
            return employee;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<EmployeeDetailDto>> GetById(int id)
        {
            var employee = await employeesApplication.GetEmployee(id);
            return employee;
        }

        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] EmployeeForCreateDto employeeForCreateDto)
        {
            await employeesApplication.InsetEmployee(employeeForCreateDto);
            return Ok();
        }
    }
}
