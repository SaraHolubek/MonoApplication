using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Service.Models;
using PagedList;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    public class VehicleMakeController : Controller
    {
        private CompanyContext db = new CompanyContext();
        private object searchString;


        // GET: VehicleMake
        public ViewResult Index(string sortOrder, string currentFilter, string searchString,int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.AbrvSortParm = String.IsNullOrEmpty(sortOrder) ? "abrv_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
          
            }

            var vehicles = from v in db.VehicleMakes
                           select v;
            if (!String.IsNullOrEmpty(searchString))
            {
                vehicles = vehicles.Where(v => v.VehicleName.Contains(searchString));
                                       
            }
            switch (sortOrder)
            {
                case "name_desc":
                    vehicles = vehicles.OrderByDescending(v => v.VehicleName);
                    break;
                case "abrv_desc":
                    vehicles = vehicles.OrderByDescending(v => v.VehicleAbrv);
                    break;
                default:
                    vehicles = vehicles.OrderBy(v => v.VehicleName);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(vehicles.ToPagedList(pageNumber, pageSize));
        }



        // GET: VehicleMake/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleMake vehicleMake = await db.VehicleMakes.FindAsync(id);
            if (vehicleMake == null)
            {
                return HttpNotFound();
            }
            return View(vehicleMake);
        }

        // GET: VehicleMake/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleMake/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,VehicleName,VehicleAbrv")] VehicleMake vehicleMake)
        {
            if (ModelState.IsValid)
            {
                db.VehicleMakes.Add(vehicleMake);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(vehicleMake);
        }

        // GET: VehicleMake/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleMake vehicleMake = await db.VehicleMakes.FindAsync(id);
            if (vehicleMake == null)
            {
                return HttpNotFound();
            }
            return View(vehicleMake);
        }

        // POST: VehicleMake/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,VehicleName,VehicleAbrv")] VehicleMake vehicleMake)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicleMake).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vehicleMake);
        }

        // GET: VehicleMake/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleMake vehicleMake = await db.VehicleMakes.FindAsync(id);
            if (vehicleMake == null)
            {
                return HttpNotFound();
            }
            return View(vehicleMake);
        }

        // POST: VehicleMake/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            VehicleMake vehicleMake = await db.VehicleMakes.FindAsync(id);
            db.VehicleMakes.Remove(vehicleMake);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
