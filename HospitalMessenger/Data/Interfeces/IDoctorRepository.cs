using HospitalMessenger.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMessenger.Data.Interfeces
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> Doctors { get;}
        Doctor GetDoctorById(int doctorId);
        //add delete update
    }
}
