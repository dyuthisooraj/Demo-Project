using antiforgery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace antiforgery.Controllers
{
    public class userController : Controller
    {
        // GET: user
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index()
        {

            return View();
        }

       
        public ActionResult Index(user u)
        {
            
            string name = u.name;
            int age=u.age;
            
            return View();
        }
    }
}