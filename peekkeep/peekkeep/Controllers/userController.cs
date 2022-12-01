using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace peekkeep.Controllers
{
    public class userController : Controller
    {
        // GET: user
        public ActionResult Index()
        {
            TempData["name"] = "dyuthi";

            return View();
        }


        public ActionResult ResultTemp()
        {
            string name;
            if (TempData.ContainsKey("name"))
                name = TempData["name"].ToString();


            return View();
        }
    }
}