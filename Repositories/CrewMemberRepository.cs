using Flight_Management_Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Repositories
{
   public  class CrewMemberRepository
    {
        private readonly FlightContext _flightContext;
        public CrewMemberRepository(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }
        // Get all crew members
        public IEnumerable<CrewMember> GetAllCrewMembers()
        {
            return _flightContext.CrewMembers.ToList();
        }
        // Get crew member by ID
        public CrewMember GetCrewMemberById(int id)
        {
            return _flightContext.CrewMembers.FirstOrDefault(cm => cm.CrewId == id);
        }
        // Add a new crew member
        public void Add(CrewMember crewMember)
        {
            _flightContext.CrewMembers.Add(crewMember);
            _flightContext.SaveChanges();
        }
        // Update an existing crew member
        public void Update(CrewMember crewMember)
        {
            _flightContext.CrewMembers.Update(crewMember);
            _flightContext.SaveChanges();
        }
        // Delete a crew member
        public void Delete(int id)
        {
            var crewMember = _flightContext.CrewMembers.Find(id);
            if (crewMember != null)
            {
                _flightContext.CrewMembers.Remove(crewMember);
                _flightContext.SaveChanges();
            }
        }
           

    }
}
