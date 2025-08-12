using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Models
{
    public class Baggage
    {
        [Key]
        public int BaggageId { get; set; }

        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal WeightKg { get; set; }

        public string TagNumber { get; set; }

    }
}
