using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string SeatNumber { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Fare { get; set; }
        public bool CheckedIn { get; set; }
        public int BookingId { get; set; }
        public booking Booking { get; set; }

        public int FlightId { get; set; }
        public Flight Flight { get; set; }
     

        public ICollection<Baggage> Baggages { get; set; }
    }

}
