using HalcyonApparelsMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HalcyonApparelsMVC.Controllers
{
   
    public class LoginMVCController : Controller
    {
        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Login(AdminLoginMVC loginDetails)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7169");
            var postTask = client.PostAsJsonAsync("api/Login", loginDetails);
            postTask.Wait();
            var Result = postTask.Result;
            if (!Result.IsSuccessStatusCode)
            {
                return BadRequest("User wrong");
            }
            return RedirectToAction("AccessoryView", "Home");
        }

        
    }
}
