using HospitalMVC.Data;
using HospitalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Web.Mvc;

namespace HospitalMVC.Controllers
{
    public class DoctorsController : Controller
    {
        HospitalContext db = new HospitalContext();

        public ActionResult Index()
        {
            return View(db.Doctors.ToList());
        }

        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(Doctor d)
        {
            db.Doctors.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
