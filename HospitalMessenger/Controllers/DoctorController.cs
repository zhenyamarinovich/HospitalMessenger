using HospitalMessenger.Data.Interfeces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMessenger.Controllers
{
    public class DoctorController:Controller
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public ViewResult List()
        {
            ViewBag.Name = "Список";
            var doctors = _doctorRepository.Doctors;
            return View(doctors);
        }
    }
}
