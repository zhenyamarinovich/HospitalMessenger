using HospitalMessenger.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalMessenger.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor {
                    DoctorId = 1,
                    Name = "Иван",
                    Surname = "Иванов",
                    MiddleName = "Иванович",
                    Age = 30,
                    ImageUrl = "https://localhost:5001/Images/doktor.jpg",
                    Position = "Хирург"
                },
                new Doctor
                {
                    DoctorId = 2,
                    Name = "Петр",
                    Surname = "Петров",
                    MiddleName = "Петрович",
                    Age = 35,
                    ImageUrl = "https://localhost:5001/Images/doktor.jpg",
                    Position = "Хирург"
                });      
        }
    }
}

