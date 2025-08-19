using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Models
{
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string PassportNo { get; set; }
        public string Nationality { get; set; }
        public bool IsVIP { get; set; }
        public int TotalFlights { get; set; }
        public DateTime DOB { get; set; }
    }

}
