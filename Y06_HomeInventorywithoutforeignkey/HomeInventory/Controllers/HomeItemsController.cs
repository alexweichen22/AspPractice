using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using HomeInventory.Helpers;
using HomeInventory.Infrastructure;
using HomeInventory.Models;
using HomeInventory.ViewModels;


namespace HomeInventory.Controllers
{
    public class HomeItemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HomeItems
        public ActionResult Index(string searchString)
        {
            ViewBag.SearchString = searchString;
            var homeItems = db.HomeItems.Include(h => h.Location).Include(h => h.PurchaseInfo).OrderBy(h => h.Description).AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
                homeItems = homeItems.Where(s => s.Description.Contains(searchString));
            return View(homeItems.ToList());
        }

        // GET: HomeItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeItem homeItem = db.HomeItems.Include(p => p.PurchaseInfo).Where(p => p.HomeItemId == id).FirstOrDefault();
            if (homeItem == null)
            {
                return HttpNotFound();
            }
            Mapper.CreateMap<HomeItem, HomeItemViewModel>().ForMember(x => x.Photo, opt => opt.Ignore());
            
            var inventoryVM = Mapper.Map<HomeItemViewModel>(homeItem);
            inventoryVM.PhotoDB = homeItem.Photo;
            return View(inventoryVM);
        }

        // GET: HomeItems/Create
        public ActionResult Create()
        {
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name");
            ViewBag.PurchaseInfoId = new SelectList(db.PurchaseInfoes, "PurchaseInfoId", "Where");
            return View();
        }

        // POST: HomeItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HomeItemViewModel homeItemVM)
        {
            if (ModelState.IsValid)
            {
                HomeItem homeItem = new HomeItem();
                homeItem.LocationId = homeItemVM.LocationId;
                homeItem.Description = homeItemVM.Description;
                homeItem.Model = homeItemVM.Model;
                homeItem.SerialNumber = homeItemVM.SerialNumber;
                if (homeItemVM.Photo != null)
                    homeItem.Photo = ImageConverter.ByteArrayFromPostedFile(homeItemVM.Photo);
                PurchaseInfo purchaseInfo = new PurchaseInfo();
                purchaseInfo.When = homeItemVM.PurchaseInfo.When;
                purchaseInfo.Where = homeItemVM.PurchaseInfo.Where;
                purchaseInfo.Warranty = homeItemVM.PurchaseInfo.Warranty;
                purchaseInfo.Price = homeItemVM.PurchaseInfo.Price;
                homeItem.PurchaseInfo = purchaseInfo;
                db.HomeItems.Add(homeItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name", homeItemVM.LocationId);
            return View(homeItemVM);
        }

        // GET: HomeItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeItem homeItem = db.HomeItems.Include(p => p.PurchaseInfo).Where(p => p.HomeItemId == id).FirstOrDefault();
            if (homeItem == null)
            {
                return HttpNotFound();
            }
            Mapper.CreateMap<HomeItem, HomeItemViewModel>().ForMember(x => x.Photo, opt => opt.Ignore());

            var inventoryVM = Mapper.Map<HomeItemViewModel>(homeItem);
            inventoryVM.PhotoDB = homeItem.Photo;
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name", homeItem.LocationId);

            return View(inventoryVM);
        }

        // POST: HomeItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( HomeItemViewModel inventoryVM)
        {
            if (ModelState.IsValid)
            {
                HomeItem homeItem = db.HomeItems.Find(inventoryVM.HomeItemId);
                if (inventoryVM != null && inventoryVM.Photo != null)
                    homeItem.Photo = ImageConverter.ByteArrayFromPostedFile(inventoryVM.Photo);
                homeItem.Description = inventoryVM.Description;
                homeItem.Model = inventoryVM.Model;
                homeItem.LocationId = inventoryVM.LocationId;
                homeItem.SerialNumber = inventoryVM.SerialNumber;
                homeItem.PurchaseInfo = inventoryVM.PurchaseInfo;
                db.Entry(homeItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Name", inventoryVM.LocationId);

            return View(inventoryVM);
        }

        // GET: HomeItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            HomeItem homeItem = db.HomeItems.Include(p => p.PurchaseInfo ).Include(p=>p.Location).Where(p => p.HomeItemId == id).FirstOrDefault();
            if (homeItem == null)
            {
                return HttpNotFound();
            }
            Mapper.CreateMap<HomeItem, HomeItemViewModel>().ForMember(x => x.Photo, opt => opt.Ignore());

            var inventoryVM = Mapper.Map<HomeItemViewModel>(homeItem);
            inventoryVM.PhotoDB = homeItem.Photo;
            return View(inventoryVM);
        }

        // POST: HomeItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomeItem homeItem = db.HomeItems.Find(id);
            db.HomeItems.Remove(homeItem);
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
