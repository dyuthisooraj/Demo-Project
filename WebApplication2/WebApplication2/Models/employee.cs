using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class employee
    {
        [Required]
        public string name
        {
            get; set;
        }

        public int age
        {
            get; set;
        }

        public double salary
        {
            get; set;
        }
    }
}