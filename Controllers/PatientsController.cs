using HospitalMVC.Data;
using HospitalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Web.Mvc;

namespace HospitalMVC.Controllers
{
    public class PatientsController : Controller
    {
        HospitalContext db = new HospitalContext();

        public ActionResult Index()
        {
            return View(db.Patients.ToList());
        }

        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(Patient p)
        {
            db.Patients.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
