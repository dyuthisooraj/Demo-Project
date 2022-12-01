using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModelEmployeefinal;

namespace WebApplication3.Controllers
{
    public class empController : Controller
    {
        // GET: emp
        public ActionResult CompleteDetails()
        {

    
            employeebasic e=new employeebasic()
            {
                name="Anand",
                age=25,
                department="Delivery",
                salary=300000.0
            };

            salarybreakup s = new salarybreakup()
            {
                hra = 5500.0,
                da = 5000.0,
                basic = 8750.0,
                sa = 5750.0
            };

            Employeefinal viewmodelemp = new Employeefinal()
            {
                employeeb = e,
                salaryb = s,
                pagename = "EmployeeDetails"
            };
            return View(viewmodelemp);
        }


    }
}