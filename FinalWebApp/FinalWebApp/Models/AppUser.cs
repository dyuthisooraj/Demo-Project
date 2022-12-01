using System.Diagnostics;

namespace FinalWebApp.Models
{
    public class AppUser
    {

        public int? Pace { get; set; }

        public int? Mileage { get; set; }

        public Address? Address  { get; set; }

        public ICollection<Clubs>? Clubs { get; set; }
        public ICollection<Races>? Races { get; set; }

    }
}
