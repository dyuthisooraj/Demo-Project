using System;
using System.Collections.Generic;

namespace EmployeeApp.Domain
{
    public partial class RegistrationNew
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? EmailId { get; set; }
        public int? MobileNumber { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public byte[]? Image { get; set; }
        public int EmpId { get; set; }
    }
}
