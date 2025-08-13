using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Flight_Management_Company.Models;

namespace Flight_Management_Company
{
    public class FlightContext: DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> options)
          : base(options)
        {
        }
        public DbSet<Airpot> Airports { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<CrewMember> CrewMembers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<booking> Bookings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<FlightCrew> FlightCrews { get; set; }
        public DbSet<Baggage> Baggages { get; set; }
        public DbSet<AircraftMaintenance> AircraftMaintenances { get; set; }

       // public FlightContext(DbContextOptions<FlightContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite PK for FlightCrew
            modelBuilder.Entity<FlightCrew>()
                .HasKey(fc => new { fc.FlightId, fc.CrewId });

            modelBuilder.Entity<FlightCrew>()
                .HasOne(fc => fc.Flight)
                .WithMany(f => f.FlightCrews)
                .HasForeignKey(fc => fc.FlightId);

            modelBuilder.Entity<FlightCrew>()
                .HasOne(fc => fc.CrewMember)
                .WithMany(c => c.FlightCrews)
                .HasForeignKey(fc => fc.CrewId);

            // Unique constraints
            modelBuilder.Entity<Airpot>()
                .HasIndex(a => a.IATA)
                .IsUnique();

            modelBuilder.Entity<Aircraft>()
                .HasIndex(a => a.TailNumber)
                .IsUnique();

            modelBuilder.Entity<Passenger>()
                .HasIndex(p => p.PassportNo)
                .IsUnique();

            modelBuilder.Entity<booking>()
                .HasIndex(b => b.BookingRef)
                .IsUnique();

            // Unique constraint on (FlightNumber, DepartureDate)
            modelBuilder.Entity<Flight>()
                .Property<DateTime>("DepartureDate")
                .HasComputedColumnSql("CAST([DepartureUtc] AS date)");

            modelBuilder.Entity<Flight>()
                .HasIndex("FlightNumber", "DepartureDate")
                .IsUnique();

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ticket>()
            .Property(t => t.Fare)
            .HasColumnType("decimal(10,2)");

            modelBuilder.Entity<Baggage>()
                .Property(b => b.WeightKg)
                .HasColumnType("decimal(6,2)");

            modelBuilder.Entity<Route>()
          .HasOne(r => r.OriginAirport)
          .WithMany(a => a.OriginRoutes)
          .HasForeignKey(r => r.OriginAirportId)
          .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Route>()
          .HasOne(r => r.DestinationAirport)
          .WithMany(a => a.DestinationRoutes)
          .HasForeignKey(r => r.DestinationAirportId)
          .OnDelete(DeleteBehavior.Restrict);

        }
    }

}
