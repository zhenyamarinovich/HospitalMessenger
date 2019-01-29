using HospitalMessenger.Data.Interfeces;
using HospitalMessenger.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMessenger.Data.Mocks
{
    public class MockDoctorRepository : IDoctorRepository
    {
        public IEnumerable<Doctor> Doctors
        {
            get
            {
                return new List<Doctor>
                {
                    new Doctor
                    {
                        Name="Иванов",
                        Surname="Иван",
                        MiddleName="Иванович",
                        Age=35,
                        Position="Старший хирург",
                        ImageUrl=""
                    },
                    new Doctor
                    {
                        Name = "Петров",
                        Surname = "Петр",
                        MiddleName = "Петрович",
                        Age = 25,
                        Position = "Хирург",
                        ImageUrl = ""
                    }
                };
            }
        }

        public Doctor GetDoctorById(int doctorId)
        {
            throw new NotImplementedException();
        }
    }
}
