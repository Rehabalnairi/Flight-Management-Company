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
        public int FlightAId { get; set; }
        public int FlightBId { get; set; }
        public DateTime FlightADep { get; set; }
        public DateTime FlightBDep { get; set; }
    }
    public class ItinSegmentDto
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepUtc { get; set; }
        public DateTime ArrUtc { get; set; }
    }

    public class PassengerItineraryDto
    {
        public int PassengerId { get; set; }
        public string PassengerName { get; set; }
        public List<ItinSegmentDto> Segments { get; set; }
    }

  
}
