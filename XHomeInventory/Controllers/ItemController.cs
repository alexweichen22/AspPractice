using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using XHomeInventory.Helper;
using XHomeInventory.Models;
using XHomeInventory.ViewModels;

namespace XHomeInventory.Controllers
{
    public class ItemController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Item
        // Default index
        /*
        public ActionResult Index()
        {
            return View(db.Items.ToList());
        }*/

        public ActionResult Index(string searchString)
        {
            ViewBag.searchString = searchString;

            var items = db.Items.AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                items = items.Where(s => s.SerialNo.Contains(searchString));
            }

            return View(items.ToList());
        }


        // GET: Item/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SerialNo,Model,Location,Description,Photo,When,Where,Warranty,Price")] ItemViewModel itemVM)
        {

            if (ModelState.IsValid)
            {
                var item = new Item();
                item.Description = itemVM.Description;
                item.Location = itemVM.Location;
                item.Model = itemVM.Model;
                item.SerialNo = itemVM.SerialNo;
                item.When = itemVM.When;
                item.Where = itemVM.Where;
                item.Warranty = itemVM.Warranty;
                item.Price = itemVM.Price;

                //adding photo to the object
                if (itemVM.Photo != null)
                {
                    item.Photo = ImageConverter.ByteArrayFromPostedFile(itemVM.Photo);
                }

                db.Items.Add(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(itemVM);
        }

        // GET: Item/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Item/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SerialNo,Model,Location,Description,Photo,When,Where,Warranty,Price")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: Item/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Item/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = db.Items.Find(id);
            db.Items.Remove(item);
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
