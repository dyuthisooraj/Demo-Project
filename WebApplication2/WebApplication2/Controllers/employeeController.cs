using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class employeeController : Controller
    {
        // GET: employee
        public ActionResult Index()
        {
            employee emp = new employee()
            {

                name = "amala",
                age = 29,
                salary = 2340000
            };
            return View(emp);
        }
    }
}