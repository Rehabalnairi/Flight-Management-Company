using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Models
{
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
}
