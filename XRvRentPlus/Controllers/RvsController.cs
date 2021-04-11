using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using XRvRentPlus.Models;

namespace XRvRentPlus.Controllers
{
    public class RvsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rvs
        public ActionResult Index()
        {
            return View(db.Rvs.ToList());
        }

        // GET: Rvs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rv rv = db.Rvs.Find(id);
            if (rv == null)
            {
                return HttpNotFound();
            }
            return View(rv);
        }

        // GET: Rvs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rvs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Rv rv)
        {
            if (ModelState.IsValid)
            {
                db.Rvs.Add(rv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rv);
        }

        // GET: Rvs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rv rv = db.Rvs.Find(id);
            if (rv == null)
            {
                return HttpNotFound();
            }
            return View(rv);
        }

        // POST: Rvs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Rv rv)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rv).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rv);
        }

        // GET: Rvs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rv rv = db.Rvs.Find(id);
            if (rv == null)
            {
                return HttpNotFound();
            }
            return View(rv);
        }

        // POST: Rvs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rv rv = db.Rvs.Find(id);
            db.Rvs.Remove(rv);
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
