using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Flight_Management_Company
{
    public class FlightContext: DbContext
    {
        public DbSet<Airpot> Airports { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<CrewMember> CrewMembers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightCrew> FlightCrews { get; set; }
        public DbSet<AircraftMaintenance> AircraftMaintenances { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API configurations can go here if needed
        }
    }
   
}
