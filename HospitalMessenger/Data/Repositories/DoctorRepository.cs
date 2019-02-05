using HospitalMessenger.Data.Interfeces;
using HospitalMessenger.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMessenger.Data.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext _appDbContext;
        public DoctorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Doctor> Doctors => _appDbContext.Doctors;

        public Doctor GetDoctorById(int doctorId) => _appDbContext.Doctors.FirstOrDefault(p => p.DoctorId == doctorId);

    }
}
