using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Appwithdatabase.Models;

namespace Appwithdatabase.Data
{
    public class AppwithdatabaseContext : DbContext
    {
        public AppwithdatabaseContext (DbContextOptions<AppwithdatabaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();

        }

        public DbSet<Appwithdatabase.Models.Employee> Employee { get; set; }
    }
}
