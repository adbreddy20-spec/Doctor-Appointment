using HospitalMVC.Data;
using HospitalMVC.Models;
using HospitalMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Web.Mvc;

namespace HospitalMVC.Controllers
{
    public class AppointmentsController : Controller
    {
        HospitalContext db = new HospitalContext();
        EmailService email = new EmailService();

        public ActionResult Index()
        {
            return View(db.Appointments.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.Patients = db.Patients.ToList();
            ViewBag.Doctors = db.Doctors.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Appointment a)
        {
            db.Appointments.Add(a);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Approve(int id)
        {
            var appt = db.Appointments.Find(id);
            if (appt == null) return HttpNotFound();

            appt.IsApproved = true;
            db.SaveChanges();

            var patient = db.Patients.First(p => p.Id == appt.PatientId);

            email.Send(
                patient.Email,
                "Appointment Approved",
                $"Hi {patient.Name}, your appointment is approved at {appt.Time}"
            );

            return RedirectToAction("Index");
        }
    }
}
