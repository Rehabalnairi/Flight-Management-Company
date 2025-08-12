using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required]
        public int OriginAirportId { get; set; }
        [ForeignKey("OriginAirportId")]
        public Airpot OriginAirport { get; set; }

        [Required]
        public int DestinationAirportId { get; set; }
        [ForeignKey("DestinationAirportId")]
        public Airpot DestinationAirport { get; set; }

        public ICollection<Flight> Flights { get; set; }

    }

    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        [Required]
        public string FlightNumber { get; set; }
        [Required]  
        public DateTime DepartureUtc { get; set; }
        [Required]
        public DateTime ArrivalUtc { get; set; }
        [Required]
        public string Status { get; set; }
        public string Note { get; set; }

        public int RouteId { get; set; }
        public Route Route { get; set; }

        public int AircraftId { get; set; }
        public Aircraft Aircraft { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<FlightCrew> FlightCrews { get; set; }
    }
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }
        [Required]
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
        [Required]
        public DateTime BookingDate { get; set; }
        [Required]
        public string status { get; set; } // e.g., Confirmed, Cancelled
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

    }
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string SeatNumber { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Fare { get; set; }
        public bool CheckedIn { get; set; }
        public int BookingId { get; set; }
        public booking Booking { get; set; }

        public int FlightId { get; set; }
        public Flight Flight { get; set; }

        public ICollection<Baggage> Baggages { get; set; }
    }
    public class FlightCrew
    {
        // Composite PK: FlightId + CrewId
        public int FlightId { get; set; }
        public Flight Flight { get; set; }

        public int CrewId { get; set; }
        public CrewMember CrewMember { get; set; }

        public string RoleOnFlight { get; set; }
    }

    public class Baggage
    {
        [Key]
        public int BaggageId { get; set; }

        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal WeightKg { get; set; }

        public string TagNumber { get; set; }
       
    }

    public class AircraftMaintenance
    {
        [Key]
        public int MaintenanceId { get; set; }
        [Required]
        public DateTime MaintenanceDate { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; } // e.g., Completed, Pending
        public int AircraftId { get; set; }
        public Aircraft Aircraft { get; set; }
    }
}