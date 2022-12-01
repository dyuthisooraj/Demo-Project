using Microsoft.EntityFrameworkCore;
using EmployeeApplicationDomain;


namespace EmployeeApplicationDal
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext(DbContextOptions dboptions) : base(dboptions)
        {

        }

        public DbSet <EmployeeRegistration> Details
        {
            get; set;   
        }    
            
    }
}
