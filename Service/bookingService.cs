using Flight_Management_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
     public  class bookingService
    {
        private readonly FlightContext _flightContext;
        public bookingService(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
        public void SeedBookingsAndTickets()
        {
            if (_flightContext.Bookings.Any()) return;

            var random = new Random();
            var passengers = _flightContext.Passengers.ToList();
            var flights = _flightContext.Flights.ToList();

            var bookings = new List<booking>();
            var tickets = new List<Ticket>();

            for (int i = 1; i <= 100; i++)
            {
                var passenger = passengers[random.Next(passengers.Count)];
                var booking = new booking
                {
                    BookingRef = "BKG" + i.ToString("D4"),
                    BookingDate = DateTime.UtcNow.AddDays(-random.Next(60)),
                    status = "Confirmed",
                    PassengerId = passenger.PassengerId
                };
                bookings.Add(booking);
            }

            _flightContext.Bookings.AddRange(bookings);
            _flightContext.SaveChanges(); 

      
            foreach (var booking in bookings)
            {
                int ticketsPerBooking = random.Next(1, 3); 
                var usedFlights = new HashSet<int>();

                for (int t = 0; t < ticketsPerBooking; t++)
                {
                    Flight flight;
                    do
                    {
                        flight = flights[random.Next(flights.Count)];
                    } while (usedFlights.Contains(flight.FlightId));

                    usedFlights.Add(flight.FlightId);

                    tickets.Add(new Ticket
                    {
                        BookingId = booking.BookingId,
                        FlightId = flight.FlightId,
                        SeatNumber = random.Next(1, flight.Aircraft.Capacity + 1).ToString() + "A",
                        Fare = Math.Round((decimal)(random.Next(100, 1000) + random.NextDouble()), 2),
                        CheckedIn = false
                    });
                }
            }

            _flightContext.Tickets.AddRange(tickets);
            _flightContext.SaveChanges();
        }
    }
}
