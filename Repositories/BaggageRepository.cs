using Flight_Management_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Repositories
{
     public class BaggageRepository
    {
        private readonly FlightContext _flightContext;
        public BaggageRepository(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
        // Get all baggage records
        public IEnumerable<Baggage> GetAllBaggages()
        {
            return _flightContext.Baggages.ToList();
        }
        // Get baggage by ID
        public Baggage GetBaggageById(int id)
        {
            return _flightContext.Baggages.FirstOrDefault(b => b.BaggageId == id);
        }
        // Add a new baggage record
        public void Add(Baggage baggage)
        {
            _flightContext.Baggages.Add(baggage);
            _flightContext.SaveChanges();
        }
        // Update an existing baggage record
        public void Update(Baggage baggage)
        {
            _flightContext.Baggages.Update(baggage);
            _flightContext.SaveChanges();
        }
        // Delete a baggage record
        public void Delete(int id)
        {
            var baggage = _flightContext.Baggages.Find(id);
            if (baggage != null)
            {
                _flightContext.Baggages.Remove(baggage);
                _flightContext.SaveChanges();
            }
        }
    }
}
