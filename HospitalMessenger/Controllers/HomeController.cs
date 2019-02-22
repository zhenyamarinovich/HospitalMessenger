using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalMessenger.Data.Interfeces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalMessenger.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDoctorRepository _doctorRepository;

        public HomeController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public ViewResult Index()
        {
            return View();
        }
    }
}
