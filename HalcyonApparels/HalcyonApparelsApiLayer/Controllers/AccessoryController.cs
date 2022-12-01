using HalcyonApparelsApplicationLayer.Interface;
using HalcyonApparelsDomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HalcyonApparelsApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessoryController : ControllerBase
    {
        private readonly IAccessory _accsry;
        public AccessoryController(IAccessory accsry)
        {
            _accsry = accsry;
        }

        [HttpGet("Get")]

        public ActionResult<List<AccessoryDetails>> Get()
        {
            var result = _accsry.Get();
            return Ok(result);
        }

        [HttpPost("Post")]
        //[Route]
        public IActionResult Post(AccessoryDetails accsry1)
        {
            if (!ModelState.IsValid)
                return BadRequest("Is not valid");
            _accsry.Post(accsry1);
            return Ok();
        }
    }
}
