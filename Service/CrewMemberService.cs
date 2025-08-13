using Flight_Management_Company.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Service
{
    public class CrewMemberService
    {
        private readonly FlightContext _flightContext;
        public CrewMemberService(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
        public void SeedCrewMembers()
        {
            if (_flightContext.CrewMembers.Any()) return;
            var crewMembers = new List<CrewMember>
{
    new CrewMember { FullName = "John Smith", Role = "Pilot", BaseAirportId = 1 },
    new CrewMember { FullName = "Alice Johnson", Role = "Co-Pilot", BaseAirportId = 2 },
    new CrewMember { FullName = "Robert Brown", Role = "Flight Attendant", BaseAirportId = 3 },
    new CrewMember { FullName = "Emily Davis", Role = "Engineer", BaseAirportId = 1 },
    new CrewMember { FullName = "Michael Wilson", Role = "Pilot", BaseAirportId = 2 },
    new CrewMember { FullName = "Linda Martinez", Role = "Co-Pilot", BaseAirportId = 3 },
    new CrewMember { FullName = "William Anderson", Role = "Flight Attendant", BaseAirportId = 1 },
    new CrewMember { FullName = "Patricia Taylor", Role = "Engineer", BaseAirportId = 2 },
    new CrewMember { FullName = "David Thomas", Role = "Pilot", BaseAirportId = 3 },
    new CrewMember { FullName = "Barbara Jackson", Role = "Co-Pilot", BaseAirportId = 1 },
    new CrewMember { FullName = "James White", Role = "Flight Attendant", BaseAirportId = 2 },
    new CrewMember { FullName = "Elizabeth Harris", Role = "Engineer", BaseAirportId = 3 },
    new CrewMember { FullName = "Christopher Martin", Role = "Pilot", BaseAirportId = 1 },
    new CrewMember { FullName = "Susan Thompson", Role = "Co-Pilot", BaseAirportId = 2 },
    new CrewMember { FullName = "Daniel Garcia", Role = "Flight Attendant", BaseAirportId = 3 },
    new CrewMember { FullName = "Jessica Martinez", Role = "Engineer", BaseAirportId = 1 },
    new CrewMember { FullName = "Matthew Robinson", Role = "Pilot", BaseAirportId = 2 },
    new CrewMember { FullName = "Sarah Clark", Role = "Co-Pilot", BaseAirportId = 3 },
    new CrewMember { FullName = "Anthony Rodriguez", Role = "Flight Attendant", BaseAirportId = 1 },
    new CrewMember { FullName = "Karen Lewis", Role = "Engineer", BaseAirportId = 2 }
};


            _flightContext.CrewMembers.AddRange(crewMembers);
            _flightContext.SaveChanges();

        }
    }
}
