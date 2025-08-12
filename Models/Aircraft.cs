using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Models
{
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
}
