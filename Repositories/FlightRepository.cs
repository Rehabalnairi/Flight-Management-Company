using Flight_Management_Company.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Flight_Management_Company.Repositories
{
    public class FlightRepository 
    {
        private readonly FlightContext _flightContext;

        public FlightRepository(FlightContext flightContext)
        {
            _flightContext = _flightContext;
        }

        public IEnumerable<Flight> GetAllFlights()
        {
            return _flightContext.Flights
                .Include(f => f.Route)
                .Include(f => f.Aircraft)
                .Include(f => f.Tickets)
                .Include(f => f.FlightCrews)
                .ToList();
        }

        public Flight GetById(int id)
        {
            return _flightContext.Flights
                .Include(f => f.Route)
                .Include(f => f.Aircraft)
                .Include(f => f.Tickets)
                .Include(f => f.FlightCrews)
                .FirstOrDefault(f => f.FlightId == id);
        }

        public void Add(Flight entity)
        {
            _flightContext.Flights.Add(entity);
            _flightContext.SaveChanges();
        }

        public void Update(Flight entity)
        {
            _flightContext.Flights.Update(entity);
            _flightContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var flight = _flightContext.Flights.Find(id);
            if (flight != null)
            {
                _flightContext.Flights.Remove(flight);
                _flightContext.SaveChanges();
            }
        }
    }
}
