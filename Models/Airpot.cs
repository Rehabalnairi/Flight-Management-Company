using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Models
{
    public class Airpot
    {
        [Key]
        public int AirportId { get; set; }
        [Required, StringLength(3)]
        public string IATA { get; set; }
        [Required]
        public String Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        [Required]
        public string TimeZone { get; set; }
        public ICollection<Route> OriginRoutes { get; set; }
        public ICollection<Route> DestinationRoutes { get; set; }
    }

}
