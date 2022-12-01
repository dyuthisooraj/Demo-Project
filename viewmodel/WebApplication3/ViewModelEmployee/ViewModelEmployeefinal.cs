using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.ViewModelEmployeefinal
{
    public class Employeefinal
    {
        public employeebasic employeeb { get; set; }

        public salarybreakup salaryb { get; set; }

        public string pagename
        {
            get; set;   
        }
    }
}