using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// when they need a context at design-time (during migrations) but can’t get it from your program’s Main method.
namespace Flight_Management_Company
{
    class FlightContextFactory : IDesignTimeDbContextFactory<FlightContext>
    {
        public FlightContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FlightContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=FlightDB;Trusted_Connection=True;");

            return new FlightContext(optionsBuilder.Options);
        }
    }
  
}
