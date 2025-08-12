using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
    class AircraftMaintenanceService
    {
        private readonly FlightContext _flightContext;

            public AircraftMaintenanceService(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }

    }
}
