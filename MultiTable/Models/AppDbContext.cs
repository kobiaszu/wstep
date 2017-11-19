using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MultiTable.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("MultiTabBase")
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Contract> Contracts { get; set; }


    }
}