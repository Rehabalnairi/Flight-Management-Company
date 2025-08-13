using Flight_Management_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
    class AircraftService
    {

        private readonly FlightContext _flightContext;

        public AircraftService(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }

        public void SeedAircrafts()
        {
            if (_flightContext.Aircrafts.Any()) return;

            var aircrafts = new List<Aircraft>
            {
                new Aircraft { TailNumber = "N12345", Model = "Boeing 737", Capacity = 160 },
                new Aircraft { TailNumber = "N54321", Model = "Airbus A320", Capacity = 180 },
                new Aircraft { TailNumber = "N98765", Model = "Boeing 777", Capacity = 300 },
                new Aircraft { TailNumber = "N56789", Model = "Embraer E190", Capacity = 100 },
                new Aircraft { TailNumber = "N19283", Model = "Airbus A380", Capacity = 280 },
                new Aircraft { TailNumber = "N56473", Model = "Boeing 747", Capacity = 250 },
                new Aircraft { TailNumber = "N84736", Model = "Bombardier CRJ900", Capacity = 120 },
                new Aircraft { TailNumber = "N74829", Model = "Airbus A350", Capacity = 280 },
                new Aircraft { TailNumber = "N29384", Model = "Boeing 787", Capacity = 260 },
                new Aircraft { TailNumber = "N67583", Model = "McDonnell Douglas MD-80", Capacity = 150 }
            };

            _flightContext.Aircrafts.AddRange(aircrafts);
            _flightContext.SaveChanges();


        }
    }
}
