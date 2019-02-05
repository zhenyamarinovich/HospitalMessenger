using HospitalMessenger.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMessenger.ViewModels
{
    public class DoctorViewModel
    {
        public IEnumerable<Doctor> Doctors { get; set; }
    }
}
