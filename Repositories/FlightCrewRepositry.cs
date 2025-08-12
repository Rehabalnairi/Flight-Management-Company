using Flight_Management_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Repositories
{
    public class FlightCrewRepositry
    {
        private readonly FlightContext _flightContext;
        public FlightCrewRepositry(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
        // Get all flight crews
        public IEnumerable<FlightCrew> GetAllFlightCrews()
        {
            return _flightContext.FlightCrews.ToList();
        }
        // Get flight crew by ID
        public FlightCrew GetFlightCrewById(int id)
        {
            return _flightContext.FlightCrews.FirstOrDefault(fc => fc.FlightId == id);
        }
        // Add a new flight crew
        public void Add(FlightCrew flightCrew)
        {
            _flightContext.FlightCrews.Add(flightCrew);
            _flightContext.SaveChanges();
        }
        // Update an existing flight crew
        public void Update(FlightCrew flightCrew)
        {
            _flightContext.FlightCrews.Update(flightCrew);
            _flightContext.SaveChanges();
        }
        // Delete a flight crew
        public void Delete(int id)
        {
            var flightCrew = _flightContext.FlightCrews.Find(id);
            if (flightCrew != null)
            {
                _flightContext.FlightCrews.Remove(flightCrew);
                _flightContext.SaveChanges();
            }
        }
    }
}
