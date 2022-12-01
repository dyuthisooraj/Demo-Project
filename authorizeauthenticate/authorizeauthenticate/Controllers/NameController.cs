using Microsoft.AspNetCore.Mvc;

namespace authorizeauthenticate.Controllers
{
    public class NameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
