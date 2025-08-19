using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Models
{
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
        public double Distance { get; set; }
    }
}
