using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Models
{
    public class CrewMember
    {
        [Key]
        public int CrewId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Role { get; set; } // e.g., Pilot, Flight Attendant
        public string LicenseNo { get; set; }
        public int BaseAirportId { get; set; }
        public Airpot BaseAirport { get; set; }

        public ICollection<FlightCrew> FlightCrews { get; set; }

    }
}
