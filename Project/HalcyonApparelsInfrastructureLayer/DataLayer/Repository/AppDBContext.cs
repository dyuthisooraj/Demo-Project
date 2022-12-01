using HalcyonApparelsDomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalcyonApparelsInfrastructureLayer.DataLayer.Repository
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<AdminLogin> AdminLogin
        {
            get; set;
        }

        public DbSet<LoginCredentials> LoginCredentials
        {
            get; set;
        }

        public DbSet<AccessoryDetails> AccessoryDetails
        {
            get; set;
        }
    }
}
