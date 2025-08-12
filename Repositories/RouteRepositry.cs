using Flight_Management_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Repositories
{
     public class RouteRepositry
    {
        private readonly FlightContext _flightContext;
        public RouteRepositry(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
        // Get all routes
        public IEnumerable<Route> GetAllRoutes()
        {
            return _flightContext.Routes.ToList();
        }
        // Get route by ID
        public Route GetRouteById(int id)
        {
            return _flightContext.Routes.FirstOrDefault(r => r.RouteId == id);
        }
        // Add a new route
        public void Add(Route route)
        {
            _flightContext.Routes.Add(route);
            _flightContext.SaveChanges();
        }
        // Update an existing route
        public void Update(Route route)
        {
            _flightContext.Routes.Update(route);
            _flightContext.SaveChanges();
        }
        // Delete a route
        public void Delete(int id)
        {
            var route = _flightContext.Routes.Find(id);
            if (route != null)
            {
                _flightContext.Routes.Remove(route);
                _flightContext.SaveChanges();
            }
        }
    }
}
