using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace HalcyonApparelsMVC.Models
{
    public class AdminLoginMVC
    {
        

        
        [Required(ErrorMessage = "First Name is required")]
        [Column(TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [Column(TypeName = "varchar")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]

        
        public string? Password { get; set; }
    }
}
