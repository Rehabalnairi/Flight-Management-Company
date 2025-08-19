using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company
{
    public class CrewDto
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }
    public class FlightManifestDto
    {
        public string FlightNumber { get; set; }
        public DateTime DepartureUtc { get; set; }
        public DateTime ArrivalUtc { get; set; }
        public string OriginIATA { get; set; }
        public string DestIATA { get; set; }
        public string AircraftTail { get; set; }
        public int PassengerCount { get; set; }
        public List<CrewDto> Crew { get; set; }
        public decimal TotalBaggageWeight { get; set; }
    }


    public class RouteRevenueDto
    {
        public string Route { get; set; }
        public int RouteId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public decimal Revenue { get; set; }
        public int SeatsSold { get; set; }
        public decimal AverageFare { get; set; }
        public decimal TotalRevenue { get; set; }
    }
    public class CrewConflictDto
    {
        public int CrewId { get; set; }
        public string CrewName { get; set; }
        public string FlightANumber { get; set; }
        public DateTime FlightADeparture { get; set; }
        public DateTime FlightAArrival { get; set; }
        public string FlightBNumber { get; set; }
        public DateTime FlightBDeparture { get; set; }
        public DateTime FlightBArrival { get; set; }
    }
    public class ItinSegmentDto
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepUtc { get; set; }
        public DateTime ArrUtc { get; set; }
        public DateTime Arrival { get; set; }
    }

    public class PassengerItineraryDto
    {
        public int PassengerId { get; set; }
        public string PassengerName { get; set; }
        public int BookingId { get; set; }
        public List<ItinSegmentDto> Segments { get; set; }
    }
    //On-Time Performance
    public class OnTimePerformanceDto
    {
        public int RouteId { get; set; }
        public string RouteName { get; set; }
        public int TotalFlights { get; set; }
        public int OnTimeFlights { get; set; }
        public decimal OnTimePercentage { get; set; }
    }
    // Seat Occupancy Heatmap
    public class FlightOccupancyDto
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string RouteName { get; set; } // "OriginIATA - DestIATA"
        public int SeatsSold { get; set; }
        public int AircraftCapacity { get; set; }
        public decimal OccupancyRate { get; set; } // 0-100%
    }


    public class FlightSegmentDto
    {
        public string FlightNumber { get; set; }
        public DateTime DepartureUtc { get; set; }
        public DateTime ArrivalUtc { get; set; }
        public string Route { get; set; }
    }
    public class FrequentFlierDto
    {
        public int PassengerId { get; set; }
        public string PassengerName { get; set; }
        public int FlightCount { get; set; }
        public double TotalDistance { get; set; }
    }
   public class MaintenanceDto
    {
        public int AircraftId { get; set; }
        public string AircraftModel { get; set; }
        public double TotalFlightHours { get; set; }
        public DateTime LastMaintenanceDate { get; set; }
        public bool NeedsMaintenance { get; set; }
    }

    public class BaggageDto
    {
        public int TicketId { get; set; }

        public string PassengerName { get; set; }
        public decimal WeightKg { get; set; }

        public double TotalBaggageWeight { get; set; }
        public bool IsOverweight { get; set; }
    }

    public class RevenueDto
    {
        public DateTime Date { get; set; }
        public decimal DailyRevenue { get; set; }
        public decimal CumulativeRevenue { get; set; }
    }
    public class BookingForecastDto
    {
        public DateTime Date { get; set; }
        public int ExpectedBookings { get; set; }
    }
}