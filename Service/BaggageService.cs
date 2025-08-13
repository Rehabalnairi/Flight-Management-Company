using Flight_Management_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Flight_Management_Company.Service
{
    public class BaggageService
    {
        private readonly FlightContext _flightContext;

        public BaggageService(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }

        public void SeedBaggages()
        {
            if (_flightContext.Baggages.Any()) return;

            var random = new Random();
            var tickets = _flightContext.Tickets.ToList();

            var baggages = new List<Baggage>();

            for (int i = 1; i <= 150; i++)
            {
                var ticket = tickets[random.Next(tickets.Count)];

                baggages.Add(new Baggage
                {
                    TicketId = ticket.TicketId,
                    WeightKg = Math.Round((decimal)(random.NextDouble() * 40 + 5), 2),// between 5 and 45
                    TagNumber = "BG" + i.ToString("D4")
                });
            }

            _flightContext.Baggages.AddRange(baggages);
            _flightContext.SaveChanges();
        }
    }
}
