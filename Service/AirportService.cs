using Flight_Management_Company.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
   public class AirportService
    {
        private readonly FlightContext _flightContext;
        public  AirportService(FlightContext flightContext) {
            _flightContext = flightContext;

    }
        //add SeedAirports funcation
        public void SeedAirports()
        {
            if (_flightContext.Airports.Any()) return;

            var airports = new List<Airpot>
            {
                new Airpot { IATA = "LAX", Name = "Los Angeles Intl", City = "Los Angeles", Country = "USA", TimeZone = "PST" },
                new Airpot { IATA = "JFK", Name = "John F. Kennedy Intl", City = "New York", Country = "USA", TimeZone = "EST" },
                new Airpot { IATA = "DXB", Name = "Dubai Intl", City = "Dubai", Country = "UAE", TimeZone = "GST" },
                new Airpot { IATA = "LHR", Name = "London Heathrow", City = "London", Country = "UK", TimeZone = "GMT" },
                new Airpot { IATA = "CDG", Name = "Charles de Gaulle", City = "Paris", Country = "France", TimeZone = "CET" },
                new Airpot { IATA = "HND", Name = "Tokyo Haneda", City = "Tokyo", Country = "Japan", TimeZone = "JST" },
                new Airpot { IATA = "SYD", Name = "Sydney Airport", City = "Sydney", Country = "Australia", TimeZone = "AEST" },
                new Airpot { IATA = "DXB", Name = "Dubai Intl", City = "Dubai", Country = "UAE", TimeZone = "GST" },
                new Airpot { IATA = "SIN", Name = "Singapore Changi", City = "Singapore", Country = "Singapore", TimeZone = "SGT" },
                new Airpot { IATA = "GRU", Name = "São Paulo Guarulhos", City = "São Paulo", Country = "Brazil", TimeZone = "BRT" },
            };

            _flightContext.Airports.AddRange(airports);
            _flightContext.SaveChanges();
        }
    }
}
