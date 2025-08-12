using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
   public class AirportService
    {
        private readonly FlightContext _flightContext;
        public  AirportService(FlightContext flightContext) {
            _flightContext = flightContext;

    }

    }
}
