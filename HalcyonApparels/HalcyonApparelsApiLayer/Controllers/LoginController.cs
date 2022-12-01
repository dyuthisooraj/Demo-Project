using HalcyonApparelsDomainLayer.Entities;
using HalcyonApparelsInfrastructureLayer.DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HalcyonApparelsApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly AppDBContext db;

        private readonly IConfiguration _config;
        public LoginController(AppDBContext dContext, IConfiguration configuration)
        {
            db = dContext;
            _config = configuration;
        }

        //public IActionResult Login()
        //{
        //    return View();
        //}

        [HttpPost]

        public IActionResult Login(AdminLogin adminlogin)
        {
            if (ModelState.IsValid)
            {
                var credentials = db.LoginCredentials.Where(model => model.UserName == adminlogin.UserName && model.Password == adminlogin.Password).FirstOrDefault();
                if (credentials == null)
                {
                   
                    return Ok("Login Failed");
                }
                else
                {
                    //Session["UserName"] = adminlogin.UserName;
                    return Ok("Login Success");

                }


            }
            return Ok();
        }
    }
}

