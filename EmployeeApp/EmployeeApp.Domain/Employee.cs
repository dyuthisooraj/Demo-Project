using System;
using System.Collections.Generic;

namespace EmployeeApp.Domain
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string? Designation { get; set; }
        public double? Salary { get; set; }
    }
}
