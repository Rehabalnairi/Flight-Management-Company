using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company
{
    public class Airpot
    {
        [Key]
        public int AirportId { get; set; }
        [Required,StringLength(3)]
        public string IATA { get; set; }
        [Required]
        public String Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        [Required]
        public string TimeZone { get; set; }
        public ICollection<Route> OriginRoutes { get; set; }
        public ICollection<Route> DestinationRoutes { get; set; }
    }

    public class Aircraft
    {
        [Key]
        public int AircraftId { get; set; }
        [Required]
        public string TailNumber { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public ICollection<Flight> Flights { get; set; } // Flights using this aircraft
        public ICollection<AircraftMaintenance> Maintenances { get; set; } // Crew assigned to this aircraft

    }

    public class CrewMember
    {
        [Key]
        public int CrewId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Role { get; set; } // e.g., Pilot, Flight Attendant
        public string LicenseNo { get; set; }
         public ICollection<FlightCrew> flightCrews { get; set; } // Flights this crew member is assigned to
    }
    public class Route
    {
        [Key]
        public int RouteId { get; set; }
        public int DistanceKm { get; set; }

    }

    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public DateTime DepartureUtc { get; set; }
        public DateTime ArrivalUtc { get; set; }
        public string Status { get; set; }
    }
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }
        public string FullName { get; set; }
        [Required]
        public string PassportNo { get; set; }
        public string Nationality { get; set; }
        public DateTime DOB { get; set; }
    }

    public class booking
    {
        [Key]
        public int BookingId { get; set; }
        [Required]
        public string BookingRef { get; set; }
        public DateTime BookingDate { get; set; }
        public string status { get; set; } // e.g., Confirmed, Cancelled

    }
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string SeatNumber { get; set; }
        public decimal Fare { get; set; }
        public bool CheckedIn { get; set; }
    }
    public class Baggage
    {
        [Key]
        public int BaggageId { get; set; }
        public decimal WeightKg { get; set; }
        public string TagNumber { get; set; } // e.g., Checked-in, In Transit, Delivered
    }

    public class AircraftMaintenance
    {
        [Key]
        public int MaintenanceId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; } // e.g., Completed, Pending
    }
}