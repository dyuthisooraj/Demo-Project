using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeApplicationDomain;

namespace EmployeeApplicationnew.Data
{
    public class EmployeeApplicationnewContext : DbContext
    {
        public EmployeeApplicationnewContext (DbContextOptions<EmployeeApplicationnewContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeApplicationDomain.EmployeeRegistration> EmployeeRegistration { get; set; } = default!;
    }
}
