using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class employee
    {

        
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        [Display(Name = "Student Name")]
        public string name
        {
            get; set; 
        }

        
        public int age
        {
            get; set;
        }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        //[RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string email { get; set; }
        
        
        [Required(ErrorMessage = "Please enter Mobile No")]
        [RegularExpression("^[+(]?([0-9]{3})?[-)]?([0-9]{3})?[- ]?([0-9]{4}$)", ErrorMessage = "Phone number is not valid")]
        [Display(Name = "Contact Number")]
        public string Mobile { get; set; }
    }
}