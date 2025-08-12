using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
     public  class bookingService
    {
        private readonly FlightContext _flightContext;
        public bookingService(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
    }
}
