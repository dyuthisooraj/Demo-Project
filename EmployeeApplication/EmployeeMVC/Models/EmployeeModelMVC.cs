using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace EmployeeMVC.Models
{
    public class EmployeeModelMVC
    {
       
        public string UserName { get; set; } = null!;

        public string? Title { get; set; }

        public string FirstName { get; set; } = null!;

       
        public string? LastName { get; set; }


        public string? Gender { get; set; }


        public string? EmailId { get; set; }


 
        public int? MobileNumber { get; set; }


        public string? Address { get; set; }


        public string? Country { get; set; }

   
        public int Salary { get; set; }


        public string Designation { get; set; }

        public string Image { get; set; }
    }
}
