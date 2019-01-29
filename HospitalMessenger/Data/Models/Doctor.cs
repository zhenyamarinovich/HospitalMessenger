﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMessenger.Data.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }

    }
}
