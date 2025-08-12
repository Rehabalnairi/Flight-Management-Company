using Flight_Management_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Repositories
{
   public class bookingRepository
    {
        private readonly FlightContext _flightContext;
        public bookingRepository(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
        // Get all bookings
        public IEnumerable<booking> GetAllBookings()
        {
            return _flightContext.Bookings.ToList();
        }
        // Get booking by ID
        public booking GetBookingById(int id)
        {
            return _flightContext.Bookings.FirstOrDefault(b => b.BookingId == id);
        }
        // Add a new booking
        public void Add(booking booking)
        {
            _flightContext.Bookings.Add(booking);
            _flightContext.SaveChanges();
        }
        // Update an existing booking
        public void Update(booking booking)
        {
            _flightContext.Bookings.Update(booking);
            _flightContext.SaveChanges();
        }
        // Delete a booking
        public void Delete(int id)
        {
            var booking = _flightContext.Bookings.Find(id);
            if (booking != null)
            {
                _flightContext.Bookings.Remove(booking);
                _flightContext.SaveChanges();
            }
        }

    }
}
