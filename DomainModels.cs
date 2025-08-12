using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company
{
    public class Airpot
    {
        public int AirportId { get; set; }
        public string IATA { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string TimeZone { get; set; }
    }

    public class Aircraft
    {
        public int AircraftId { get; set; }
        public string TailNumber { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }

    }

    public class CrewMember
    {
        public int CrewId { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; } // e.g., Pilot, Flight Attendant
        public string LicenseNo { get; set; }
    }
    public class Route
    {
        public int RouteId { get; set; }
        public int DistanceKm { get; set; }

    }

    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public DateTime DepartureUtc { get; set; }
        public DateTime ArrivalUtc { get; set; }
        public string Status { get; set; }
    }
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string FullName { get; set; }
        public string PassportNo { get; set; }
        public string Nationality { get; set; }
        public DateTime DOB { get; set; }
    }

    public class booking
    {
        public int BookingId { get; set; }
        public string BookingRef { get; set; }
        public DateTime BookingDate { get; set; }
        public string status { get; set; } // e.g., Confirmed, Cancelled

    }
    public class Ticket
    {
        public int TicketId { get; set; }
        public string SeatNumber { get; set; }
        public decimal Fare { get; set; }
        public bool CheckedIn { get; set; }
    }
    public class Baggage
    {
        public int BaggageId { get; set; }
        public decimal WeightKg { get; set; }
        public string TagNumber { get; set; } // e.g., Checked-in, In Transit, Delivered
    }

    public class AircraftMaintenance
    {
        public int MaintenanceId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; } // e.g., Completed, Pending
    }
}