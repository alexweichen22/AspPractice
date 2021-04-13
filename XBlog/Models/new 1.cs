using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using XRvRentPlus.Models;
using XRvRentPlus.ViewModels;

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

        public ActionResult Random()
        {
            // This is to generate a random record from database model to show it on
            // homepage (Random)
            System.Random random = new System.Random();
            int rand = random.Next(0, db.Rvs.ToList().Count());
            int i = 0;
            var rv = new Rv();
            //db.Rvs.ToList().Count;
            foreach (var temp in db.Rvs.ToList())
            {
                if (rand == i)
                {
                    rv = temp;
                    i = 0;
                    break;
                }
                i++;
            }


            
            int randCustomer = random.Next(0, db.Customers.ToList().Count());
            int j = 0;
            var customer = new Customer();
            foreach (var temp in db.Customers.ToList())
            {
                if (randCustomer == j)
                {
                    customer = temp;
                    j = 0;
                    break;
                }
                j++;
            }

            var viewModel = new RandomRvViewModel();
            viewModel.Rv = rv;
            viewModel.Customer = customer;
            viewModel.Rvs = db.Rvs.ToList();
            viewModel.Customers = db.Customers.ToList();

            return View(viewModel);

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
        public ActionResult Create([Bind(Include = "Id,Name,Photo,Brand,Model,Year")] Rv rv)
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
        public ActionResult Edit([Bind(Include = "Id,Name,Photo,Brand,Model,Year")] Rv rv)
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
