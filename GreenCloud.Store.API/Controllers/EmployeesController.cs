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
        public async Task<ActionResult<List<Employee>>> GetAll()
        {
            var employee = await employeesApplication.GetEmployees();
            return employee;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetById(int id)
        {
            var employee = await employeesApplication.GetEmployee(id);
            return employee;
        }
    }
}
