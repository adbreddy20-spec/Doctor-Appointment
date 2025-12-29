using Doctor_Appointment.Models;
using HospitalMVC.Models;
using System.Data.Entity;

namespace HospitalMVC.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext() : base("HospitalDb") { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
