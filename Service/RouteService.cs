using Flight_Management_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
     public class RouteService

    {
        private readonly FlightContext _flightContext;
        public RouteService(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
        public void SeedRoutes()
        {
            if (_flightContext.Routes.Any()) return;

            var routes = new List<Route>
            {
                new Route { OriginAirportId = 1, DestinationAirportId = 2, DistanceKm = 450 },
                new Route { OriginAirportId = 1, DestinationAirportId = 3, DistanceKm = 1200 },
                new Route { OriginAirportId = 2, DestinationAirportId = 3, DistanceKm = 900 },
                new Route { OriginAirportId = 3, DestinationAirportId = 1, DistanceKm = 1200 },
                new Route { OriginAirportId = 2, DestinationAirportId = 1, DistanceKm = 450 },
                new Route { OriginAirportId = 3, DestinationAirportId = 2, DistanceKm = 900 },
                new Route { OriginAirportId = 1, DestinationAirportId = 2, DistanceKm = 450 },
                new Route { OriginAirportId = 1, DestinationAirportId = 3, DistanceKm = 1200 },
                new Route { OriginAirportId = 2, DestinationAirportId = 3, DistanceKm = 900 },
                new Route { OriginAirportId = 3, DestinationAirportId = 1, DistanceKm = 1200 },
                new Route { OriginAirportId = 2, DestinationAirportId = 1, DistanceKm = 450 },
                new Route { OriginAirportId = 3, DestinationAirportId = 2, DistanceKm = 900 },
                new Route { OriginAirportId = 1, DestinationAirportId = 4, DistanceKm = 1500 },
                new Route { OriginAirportId = 4, DestinationAirportId = 5, DistanceKm = 700 },
                new Route { OriginAirportId = 5, DestinationAirportId = 6, DistanceKm = 650 },
                new Route { OriginAirportId = 6, DestinationAirportId = 1, DistanceKm = 1600 },
                new Route { OriginAirportId = 4, DestinationAirportId = 2, DistanceKm = 1400 },
                new Route { OriginAirportId = 5, DestinationAirportId = 3, DistanceKm = 1100 },
                new Route { OriginAirportId = 6, DestinationAirportId = 2, DistanceKm = 1350 },
                new Route { OriginAirportId = 1, DestinationAirportId = 5, DistanceKm = 1550 }
            };

            _flightContext.Routes.AddRange(routes);
            _flightContext.SaveChanges();
        }
    }
}
