using Flight_Management_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Repositories
{
     public class AirpotRepositry
    {
        private readonly FlightContext _flightContext;

        public AirpotRepositry(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
        public IEnumerable<Airpot> GetAirports()
        {
            return _flightContext.Airports.ToList();
        }

        //update 
        public void Update(Airpot airport)
        {
            _flightContext.Airports.Update(airport);
            _flightContext.SaveChanges();
        }

        //add
        public void Add(Airpot airport)
        {
            _flightContext.Airports.Add(airport);
            _flightContext.SaveChanges();
        }
        //delete

        public void delete(Airpot airport)
        {
            _flightContext.Airports.Remove(airport);
            _flightContext.SaveChanges();

        }
        //get by id
        public Airpot GetAirpotById(int id)
        {
            return _flightContext.Airports.FirstOrDefault(a => a.AirportId == id);
        }

        //get all
        public List<Airpot> GetAllAirports()
        {
            return _flightContext.Airports.ToList();
        }


    }
}
