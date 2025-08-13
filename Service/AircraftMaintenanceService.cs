using Flight_Management_Company.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
    class AircraftMaintenanceService
    {
        private readonly FlightContext _flightContext;

        public AircraftMaintenanceService(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }

        public void SeedAircraftMaintenances()
        {
            if (_flightContext.AircraftMaintenances.Any()) return;

            var random = new Random();
            var aircrafts = _flightContext.Aircrafts.ToList();
            var maintenances = new List<AircraftMaintenance>();

            for (int i = 1; i <= 15; i++)
            {
                var aircraft = aircrafts[random.Next(aircrafts.Count)];

                maintenances.Add(new AircraftMaintenance
                {
                    AircraftId = aircraft.AircraftId,
                    MaintenanceDate = DateTime.UtcNow.AddDays(-random.Next(60)), // lor last 60 days ago
                    Type = i % 2 == 0 ? "Routine Check" : "Repair",
                    Notes = i % 2 == 0 ? "Completed" : "Pending"
                });
            }

            _flightContext.AircraftMaintenances.AddRange(maintenances);
            _flightContext.SaveChanges();
        }

    }
}



    
