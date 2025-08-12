using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Models
{
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
        public ICollection<CrewMember> CrewMembers { get; set; } // Crew assigned to this maintenance task
    }
}
