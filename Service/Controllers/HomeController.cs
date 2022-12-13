using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Service.DAL;
using Service.Models;
using Service.ViewModels;

namespace Service.Controllers
{
    public class HomeController : Controller
    {
        private CompanyContext db = new CompanyContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<RegistratedCarsGroup> data = from vehicle in db.VehicleMakes
                                                    group vehicle by vehicle.VehicleName into stringGroup
                                                    select new RegistratedCarsGroup()
                                                    {
                                                        VehicleName = stringGroup.Key,
                                                       VehicleCount = stringGroup.Count()
                                                   };
            return View(data.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}