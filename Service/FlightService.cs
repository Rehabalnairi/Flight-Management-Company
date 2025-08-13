using Flight_Management_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
    public class FlightService

    {
        private readonly FlightContext _flightContext;
        public FlightService(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
        public void SeedFlights()
        {
            if (_flightContext.Flights.Any()) return;
            var random = new Random();

            var flights = new List<Flight>
{
    new Flight { FlightNumber="FL101", RouteId=1, AircraftId=1, DepartureUtc=DateTime.UtcNow.AddDays(31).AddHours(10), ArrivalUtc=DateTime.UtcNow.AddDays(31).AddHours(14), Status="Scheduled" },
    new Flight { FlightNumber="FL102", RouteId=2, AircraftId=2, DepartureUtc=DateTime.UtcNow.AddDays(32).AddHours(9), ArrivalUtc=DateTime.UtcNow.AddDays(32).AddHours(13), Status="Departed" },
    new Flight { FlightNumber="FL103", RouteId=3, AircraftId=3, DepartureUtc=DateTime.UtcNow.AddDays(33).AddHours(8), ArrivalUtc=DateTime.UtcNow.AddDays(33).AddHours(12), Status="Landed" },
    new Flight { FlightNumber="FL104", RouteId=4, AircraftId=4, DepartureUtc=DateTime.UtcNow.AddDays(34).AddHours(7), ArrivalUtc=DateTime.UtcNow.AddDays(34).AddHours(11), Status="Scheduled" },
    new Flight { FlightNumber="FL105", RouteId=5, AircraftId=5, DepartureUtc=DateTime.UtcNow.AddDays(35).AddHours(6), ArrivalUtc=DateTime.UtcNow.AddDays(35).AddHours(10), Status="Departed" },
    new Flight { FlightNumber="FL106", RouteId=6, AircraftId=6, DepartureUtc=DateTime.UtcNow.AddDays(36).AddHours(5), ArrivalUtc=DateTime.UtcNow.AddDays(36).AddHours(9), Status="Landed" },
    new Flight { FlightNumber="FL107", RouteId=7, AircraftId=1, DepartureUtc=DateTime.UtcNow.AddDays(37).AddHours(11), ArrivalUtc=DateTime.UtcNow.AddDays(37).AddHours(15), Status="Scheduled" },
    new Flight { FlightNumber="FL108", RouteId=8, AircraftId=2, DepartureUtc=DateTime.UtcNow.AddDays(38).AddHours(12), ArrivalUtc=DateTime.UtcNow.AddDays(38).AddHours(16), Status="Departed" },
    new Flight { FlightNumber="FL109", RouteId=9, AircraftId=3, DepartureUtc=DateTime.UtcNow.AddDays(39).AddHours(13), ArrivalUtc=DateTime.UtcNow.AddDays(39).AddHours(17), Status="Landed" },
    new Flight { FlightNumber="FL110", RouteId=10, AircraftId=4, DepartureUtc=DateTime.UtcNow.AddDays(40).AddHours(14), ArrivalUtc=DateTime.UtcNow.AddDays(40).AddHours(18), Status="Scheduled" },
    new Flight { FlightNumber="FL111", RouteId=1, AircraftId=5, DepartureUtc=DateTime.UtcNow.AddDays(41).AddHours(10), ArrivalUtc=DateTime.UtcNow.AddDays(41).AddHours(14), Status="Departed" },
    new Flight { FlightNumber="FL112", RouteId=2, AircraftId=6, DepartureUtc=DateTime.UtcNow.AddDays(42).AddHours(9), ArrivalUtc=DateTime.UtcNow.AddDays(42).AddHours(13), Status="Landed" },
    new Flight { FlightNumber="FL113", RouteId=3, AircraftId=1, DepartureUtc=DateTime.UtcNow.AddDays(43).AddHours(8), ArrivalUtc=DateTime.UtcNow.AddDays(43).AddHours(12), Status="Scheduled" },
    new Flight { FlightNumber="FL114", RouteId=4, AircraftId=2, DepartureUtc=DateTime.UtcNow.AddDays(44).AddHours(7), ArrivalUtc=DateTime.UtcNow.AddDays(44).AddHours(11), Status="Departed" },
    new Flight { FlightNumber="FL115", RouteId=5, AircraftId=3, DepartureUtc=DateTime.UtcNow.AddDays(45).AddHours(6), ArrivalUtc=DateTime.UtcNow.AddDays(45).AddHours(10), Status="Landed" },
    new Flight { FlightNumber="FL116", RouteId=6, AircraftId=4, DepartureUtc=DateTime.UtcNow.AddDays(46).AddHours(5), ArrivalUtc=DateTime.UtcNow.AddDays(46).AddHours(9), Status="Scheduled" },
    new Flight { FlightNumber="FL117", RouteId=7, AircraftId=5, DepartureUtc=DateTime.UtcNow.AddDays(47).AddHours(11), ArrivalUtc=DateTime.UtcNow.AddDays(47).AddHours(15), Status="Departed" },
    new Flight { FlightNumber="FL118", RouteId=8, AircraftId=6, DepartureUtc=DateTime.UtcNow.AddDays(48).AddHours(12), ArrivalUtc=DateTime.UtcNow.AddDays(48).AddHours(16), Status="Landed" },
    new Flight { FlightNumber="FL119", RouteId=9, AircraftId=1, DepartureUtc=DateTime.UtcNow.AddDays(49).AddHours(13), ArrivalUtc=DateTime.UtcNow.AddDays(49).AddHours(17), Status="Scheduled" },
    new Flight { FlightNumber="FL120", RouteId=10, AircraftId=2, DepartureUtc=DateTime.UtcNow.AddDays(50).AddHours(14), ArrivalUtc=DateTime.UtcNow.AddDays(50).AddHours(18), Status="Departed" },
    new Flight { FlightNumber="FL121", RouteId=1, AircraftId=3, DepartureUtc=DateTime.UtcNow.AddDays(51).AddHours(10), ArrivalUtc=DateTime.UtcNow.AddDays(51).AddHours(14), Status="Landed" },
    new Flight { FlightNumber="FL122", RouteId=2, AircraftId=4, DepartureUtc=DateTime.UtcNow.AddDays(52).AddHours(9), ArrivalUtc=DateTime.UtcNow.AddDays(52).AddHours(13), Status="Scheduled" },
    new Flight { FlightNumber="FL123", RouteId=3, AircraftId=5, DepartureUtc=DateTime.UtcNow.AddDays(53).AddHours(8), ArrivalUtc=DateTime.UtcNow.AddDays(53).AddHours(12), Status="Departed" },
    new Flight { FlightNumber="FL124", RouteId=4, AircraftId=6, DepartureUtc=DateTime.UtcNow.AddDays(54).AddHours(7), ArrivalUtc=DateTime.UtcNow.AddDays(54).AddHours(11), Status="Landed" },
    new Flight { FlightNumber="FL125", RouteId=5, AircraftId=1, DepartureUtc=DateTime.UtcNow.AddDays(55).AddHours(6), ArrivalUtc=DateTime.UtcNow.AddDays(55).AddHours(10), Status="Scheduled" },
    new Flight { FlightNumber="FL126", RouteId=6, AircraftId=2, DepartureUtc=DateTime.UtcNow.AddDays(56).AddHours(5), ArrivalUtc=DateTime.UtcNow.AddDays(56).AddHours(9), Status="Departed" },
    new Flight { FlightNumber="FL127", RouteId=7, AircraftId=3, DepartureUtc=DateTime.UtcNow.AddDays(57).AddHours(11), ArrivalUtc=DateTime.UtcNow.AddDays(57).AddHours(15), Status="Landed" },
    new Flight { FlightNumber="FL128", RouteId=8, AircraftId=4, DepartureUtc=DateTime.UtcNow.AddDays(58).AddHours(12), ArrivalUtc=DateTime.UtcNow.AddDays(58).AddHours(16), Status="Scheduled" },
    new Flight { FlightNumber="FL129", RouteId=9, AircraftId=5, DepartureUtc=DateTime.UtcNow.AddDays(59).AddHours(13), ArrivalUtc=DateTime.UtcNow.AddDays(59).AddHours(17), Status="Departed" },
    new Flight { FlightNumber="FL130", RouteId=10, AircraftId=6, DepartureUtc=DateTime.UtcNow.AddDays(60).AddHours(14), ArrivalUtc=DateTime.UtcNow.AddDays(60).AddHours(18), Status="Landed" }
};

            _flightContext.Flights.AddRange(flights);
            _flightContext.SaveChanges();

        }
    }
}
