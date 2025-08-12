using Flight_Management_Company.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Management_Company.Repositories
{
     public class AircraftMaintenanceRepository
    {
        private readonly FlightContext _flightContext;
        public AircraftMaintenanceRepository(FlightContext flightContext)
        {
            _flightContext = flightContext;
        }

        // Get all aircraft maintenance records
        public IEnumerable<AircraftMaintenance> GetAllMaintenances()
        {
            return _flightContext.AircraftMaintenances
                .Include(am => am.Aircraft)
                .Include(am => am.CrewMembers)
                .ToList();

        }
        // Get maintenance record by ID
        public AircraftMaintenance GetMaintenanceById(int id)
        {
            return _flightContext.AircraftMaintenances
                .Include(am => am.Aircraft)
                .Include(am => am.CrewMembers)
                .FirstOrDefault(am => am.MaintenanceId == id);
        }
        // Add a new maintenance record
        public void add(AircraftMaintenance maintenance)
        {
            _flightContext.AircraftMaintenances.Add(maintenance);
            _flightContext.SaveChanges();
        }

        // Update an existing maintenance record
        public void Update(AircraftMaintenance maintenance)
        {
            _flightContext.AircraftMaintenances.Update(maintenance);
            _flightContext.SaveChanges();
        }
        // Delete a maintenance record
        public void Delete(int id)
        {
            var maintenance = _flightContext.AircraftMaintenances.Find(id);
            if (maintenance != null)
            {
                _flightContext.AircraftMaintenances.Remove(maintenance);
                _flightContext.SaveChanges();
            }
        }

    }
}
