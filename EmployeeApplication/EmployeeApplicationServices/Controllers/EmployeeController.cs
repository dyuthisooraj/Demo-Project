using EmployeeApplicationDomain;
using EmployeeBusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeApplicationServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _emp;
        public EmployeeController(IEmployee emp)
        {
            _emp = emp;
        }
        [HttpGet("Get")]       
        public ActionResult< List<EmployeeRegistration>> Get()
        {
            var result= _emp.Get();
            return Ok(result);
        }

        [HttpPost]
        [Route("post")]
        public IActionResult Post([FromBody] EmployeeRegistration emp1)
        {
            if (!ModelState.IsValid)
                return BadRequest("Is not valid");
            _emp.Post(emp1);
            return Ok();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }


    }
}
