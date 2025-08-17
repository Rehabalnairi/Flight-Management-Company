using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Models
{
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
        public DateTime ScheduledDepartureUtc { get; set; }
        public DateTime ScheduledArrivalUtc { get; set; }


        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<FlightCrew> FlightCrews { get; set; }
    }
}
