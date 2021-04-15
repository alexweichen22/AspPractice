using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RaceRegistration.Models;

namespace RaceRegistration.Controllers
{
    public class RunnersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Runners
        /*
        public ActionResult Index()
        {
            var runners = db.Runners.Include(r => r.Country).Include(r => r.Event);
            return View(runners.ToList());
        }
        */

        public ActionResult Index(string searchString)
        {
            ViewBag.searchString = searchString;
            //ViewBag.sortOrder = sortOrder;
            //ViewBag.sortDir = sortDir;
            var runners = db.Runners.Include(r => r.Country).Include(r => r.Event).AsQueryable();
            //var runners = db.Runners.AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                runners = runners.Where(s => s.LastName.Contains(searchString));
            }

            runners = runners.OrderBy(s => s.LastName);


            return View(runners.ToList());
        }

        // GET: Runners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Runner runner = db.Runners.Find(id);
            if (runner == null)
            {
                return HttpNotFound();
            }
            return View(runner);
        }

        // GET: Runners/Create
        public ActionResult Create()
        {
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name");
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Name");
            return View();
        }

        // POST: Runners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RunnerId,FirstName,LastName,BirthDate,Gender,Email,Telephone,Address,State,PostalCode,RegistrationDate,CountryId,ContactPersonName,ContactPersonTelephone,EventId")] Runner runner)
        {
            if (ModelState.IsValid)
            {
                db.Runners.Add(runner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name", runner.CountryId);
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Name", runner.EventId);
            return View(runner);
        }

        // GET: Runners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Runner runner = db.Runners.Find(id);
            if (runner == null)
            {
                return HttpNotFound();
            }
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name", runner.CountryId);
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Name", runner.EventId);
            return View(runner);
        }

        // POST: Runners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RunnerId,FirstName,LastName,BirthDate,Gender,Email,Telephone,Address,State,PostalCode,RegistrationDate,CountryId,ContactPersonName,ContactPersonTelephone,EventId")] Runner runner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(runner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name", runner.CountryId);
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Name", runner.EventId);
            return View(runner);
        }

        // GET: Runners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Runner runner = db.Runners.Find(id);
            if (runner == null)
            {
                return HttpNotFound();
            }
            return View(runner);
        }

        // POST: Runners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Runner runner = db.Runners.Find(id);
            db.Runners.Remove(runner);
            db.SaveChanges();
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
