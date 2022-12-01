using Microsoft.AspNetCore.Mvc;
using routingattributeassignment.interfaces;
using routingattributeassignment.Models;

namespace routingattributeassignment.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployee _employee;

        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }

        [HttpGet]
        [Route("GetAllEmployee")]

        public List<Employee> Index()
        {
            return _employee.Details();
        }

        [HttpGet]
        [Route("GetEmployeebyId/{id}")]

        public Employee Details(int id) 
        {
            return _employee.Details(id);
        }


    }
}
