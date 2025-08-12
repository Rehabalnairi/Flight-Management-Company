using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
     public class TicketService
    {

        private readonly FlightContext _flightContext;
        public TicketService(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
    }
}

