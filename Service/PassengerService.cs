using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
     public class PassengerService
    {
        private readonly FlightContext _repo;
        public PassengerService(FlightContext flightContext)
        {
            flightContext = flightContext;
        }

    }
}
