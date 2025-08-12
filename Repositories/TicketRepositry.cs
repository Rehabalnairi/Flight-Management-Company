using Flight_Management_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Repositories
{
     public class TicketRepositry
    {
        private readonly FlightContext _flightContext;
        public TicketRepositry(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
        // Get all tickets
        public IEnumerable<Ticket> GetAllTickets()
        {
            return _flightContext.Tickets.ToList();
        }
        // Get ticket by ID
        public Ticket GetTicketById(int id)
        {
            return _flightContext.Tickets.FirstOrDefault(t => t.TicketId == id);
        }
        // Add a new ticket
        public void Add(Ticket ticket)
        {
            _flightContext.Tickets.Add(ticket);
            _flightContext.SaveChanges();
        }
        // Update an existing ticket
        public void Update(Ticket ticket)
        {
            _flightContext.Tickets.Update(ticket);
            _flightContext.SaveChanges();
        }
        // Delete a ticket
        public void Delete(int id)
        {
            var ticket = _flightContext.Tickets.Find(id);
            if (ticket != null)
            {
                _flightContext.Tickets.Remove(ticket);
                _flightContext.SaveChanges();
            }
        }
    }
}
