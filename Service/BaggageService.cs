using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
   public  class BaggageService
    {
        private readonly FlightContext _flightContext;
        public BaggageService(FlightContext flightContext)
        {
            _flightContext = flightContext;

        }
    }
}
