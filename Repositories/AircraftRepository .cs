using Flight_Management_Company.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Repositories
{
    public class AircraftRepository
    {
        private readonly FlightContext _flightContext;
        public AircraftRepository(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
         public IEnumerable<Aircraft> GetAircraft()
        {
            return _flightContext.Aircrafts
            .Include(a => a.Flights)
            .Include(a => a.Maintenances);
        }

        public Aircraft GetAircraftById(int id)
        {
            return _flightContext.Aircrafts
                .Include(a => a.Flights)
                .Include(a => a.Maintenances)
                .FirstOrDefault(a => a.AircraftId == id);
        }

        public void Add(Aircraft aircraft)
        {
            _flightContext.Aircrafts.Add(aircraft);
            _flightContext.SaveChanges();
        }

        public void Update(Aircraft aircraft)
        {
            _flightContext.Aircrafts.Update(aircraft);
            _flightContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var aircraft = _flightContext.Aircrafts.Find(id);
            if (aircraft != null)
            {
                _flightContext.Aircrafts.Remove(aircraft);
                _flightContext.SaveChanges();
            }
        }
      
    }
}
