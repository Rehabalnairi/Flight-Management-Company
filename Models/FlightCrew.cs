using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Models
{
    public class FlightCrew
    {
        // Composite PK: FlightId + CrewId
        public int FlightId { get; set; }
        public Flight Flight { get; set; }

        public int CrewId { get; set; }
        public CrewMember CrewMember { get; set; }

        public string RoleOnFlight { get; set; }
    }
}
