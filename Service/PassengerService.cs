using Flight_Management_Company.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
    public class PassengerService
    {
        private readonly FlightContext _flightContext;

        public PassengerService(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }

        public void SeedPassengers()
        {
            if (_flightContext.Passengers.Any()) return;

            var passengers = new List<Passenger>
{
    new Passenger { FullName="John Smith", PassportNo="P100001", Nationality="USA" },
    new Passenger { FullName="Alice Johnson", PassportNo="P100002", Nationality="Canada" },
    new Passenger { FullName="Robert Brown", PassportNo="P100003", Nationality="UK" },
    new Passenger { FullName="Emily Davis", PassportNo="P100004", Nationality="Germany" },
    new Passenger { FullName="Michael Wilson", PassportNo="P100005", Nationality="France" },
    new Passenger { FullName="Linda Martinez", PassportNo="P100006", Nationality="Spain" },
    new Passenger { FullName="William Anderson", PassportNo="P100007", Nationality="Italy" },
    new Passenger { FullName="Patricia Taylor", PassportNo="P100008", Nationality="Australia" },
    new Passenger { FullName="David Thomas", PassportNo="P100009", Nationality="Brazil" },
    new Passenger { FullName="Barbara Jackson", PassportNo="P100010", Nationality="Mexico" },
    new Passenger { FullName="James White", PassportNo="P100011", Nationality="USA" },
    new Passenger { FullName="Elizabeth Harris", PassportNo="P100012", Nationality="Canada" },
    new Passenger { FullName="Christopher Martin", PassportNo="P100013", Nationality="UK" },
    new Passenger { FullName="Susan Thompson", PassportNo="P100014", Nationality="Germany" },
    new Passenger { FullName="Daniel Garcia", PassportNo="P100015", Nationality="France" },
    new Passenger { FullName="Jessica Martinez", PassportNo="P100016", Nationality="Spain" },
    new Passenger { FullName="Matthew Robinson", PassportNo="P100017", Nationality="Italy" },
    new Passenger { FullName="Sarah Clark", PassportNo="P100018", Nationality="Australia" },
    new Passenger { FullName="Anthony Rodriguez", PassportNo="P100019", Nationality="Brazil" },
    new Passenger { FullName="Karen Lewis", PassportNo="P100020", Nationality="Mexico" },
    new Passenger { FullName="Brian Walker", PassportNo="P100021", Nationality="USA" },
    new Passenger { FullName="Nancy Hall", PassportNo="P100022", Nationality="Canada" },
    new Passenger { FullName="Kevin Allen", PassportNo="P100023", Nationality="UK" },
    new Passenger { FullName="Laura Young", PassportNo="P100024", Nationality="Germany" },
    new Passenger { FullName="Edward Hernandez", PassportNo="P100025", Nationality="France" },
    new Passenger { FullName="Megan King", PassportNo="P100026", Nationality="Spain" },
    new Passenger { FullName="Joshua Wright", PassportNo="P100027", Nationality="Italy" },
    new Passenger { FullName="Stephanie Lopez", PassportNo="P100028", Nationality="Australia" },
    new Passenger { FullName="Ryan Hill", PassportNo="P100029", Nationality="Brazil" },
    new Passenger { FullName="Rebecca Scott", PassportNo="P100030", Nationality="Mexico" },
    new Passenger { FullName="Jacob Green", PassportNo="P100031", Nationality="USA" },
    new Passenger { FullName="Olivia Adams", PassportNo="P100032", Nationality="Canada" },
    new Passenger { FullName="Nathan Baker", PassportNo="P100033", Nationality="UK" },
    new Passenger { FullName="Chloe Gonzalez", PassportNo="P100034", Nationality="Germany" },
    new Passenger { FullName="Aaron Nelson", PassportNo="P100035", Nationality="France" },
    new Passenger { FullName="Hailey Carter", PassportNo="P100036", Nationality="Spain" },
    new Passenger { FullName="Justin Mitchell", PassportNo="P100037", Nationality="Italy" },
    new Passenger { FullName="Sophia Perez", PassportNo="P100038", Nationality="Australia" },
    new Passenger { FullName="Alexander Roberts", PassportNo="P100039", Nationality="Brazil" },
    new Passenger { FullName="Grace Turner", PassportNo="P100040", Nationality="Mexico" },
    new Passenger { FullName="Benjamin Phillips", PassportNo="P100041", Nationality="USA" },
    new Passenger { FullName="Victoria Campbell", PassportNo="P100042", Nationality="Canada" },
    new Passenger { FullName="Samuel Parker", PassportNo="P100043", Nationality="UK" },
    new Passenger { FullName="Ella Evans", PassportNo="P100044", Nationality="Germany" },
    new Passenger { FullName="Daniel Edwards", PassportNo="P100045", Nationality="France" },
    new Passenger { FullName="Lily Collins", PassportNo="P100046", Nationality="Spain" },
    new Passenger { FullName="Christopher Stewart", PassportNo="P100047", Nationality="Italy" },
    new Passenger { FullName="Madison Sanchez", PassportNo="P100048", Nationality="Australia" },
    new Passenger { FullName="Joshua Morris", PassportNo="P100049", Nationality="Brazil" },
    new Passenger { FullName="Abigail Rogers", PassportNo="P100050", Nationality="Mexico" }
};


            _flightContext.Passengers.AddRange(passengers);
            _flightContext.SaveChanges();

        }
        //Top Routes by Revenue
        public IEnumerable<object> GetTopRoutesByRevenue(DateTime startDate, DateTime endDate)
        {
            return _flightContext.Flights
                .Where(f => f.DepartureUtc >= startDate && f.DepartureUtc <= endDate)
                .Include(f => f.Route)
                .Include(f => f.Tickets)
                .GroupBy(f => new { f.Route.OriginAirportId, f.Route.DestinationAirport })
                .Select(g => new
                {
                    Route = g.Key.OriginAirportId + " → " + g.Key.OriginAirportId,
                    TotalRevenue = g.Sum(f => f.Tickets.Sum(t => t.Fare)),
                    SeatsSold = g.Sum(f => f.Tickets.Count),
                    AverageFare = g.Average(f => f.Tickets.Average(t => t.Fare))
                })
                .OrderByDescending(r => r.TotalRevenue)
                .ToList();
        }



    }
}
