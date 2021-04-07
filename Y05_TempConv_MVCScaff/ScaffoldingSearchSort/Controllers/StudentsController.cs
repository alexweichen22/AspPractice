using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ScaffoldingSearchSort.Helpers;
using ScaffoldingSearchSort.Infrastructure;
using ScaffoldingSearchSort.Models;
using ScaffoldingSearchSort.ViewModels;

namespace ScaffoldingSearchSort.Controllers
{
    public class StudentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Students
        public ActionResult Index(string sortOrder, string sortDir, string searchString)
        {
            ViewBag.searchString = searchString;
            ViewBag.sortOrder = sortOrder;
            ViewBag.sortDir = sortDir;


            var students = db.Students.AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Name.Contains(searchString));
            }

            if (sortOrder != null)
            {
                switch (sortOrder.ToLower())
                {
                    case "name":
                        if (sortDir.ToLower() == "desc")
                        {
                            students = students.OrderByDescending(s => s.Name);
                        }
                        else
                        {
                            students = students.OrderBy(s => s.Name);

                        }
                        break;
                    case "enrollmentDate":
                        if (sortDir.ToLower() == "desc")
                        {
                            students = students.OrderByDescending(s => s.EnrollmentDate);
                        }
                        else
                        {
                            students = students.OrderBy(s => s.EnrollmentDate);

                        }
                        break;
                }
            }
            
            return View(students.ToList());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,EnrollmentDate,Photo")] StudentViewModel studentVM)
        {
            if (ModelState.IsValid)
            {
                var student = new Student();
                student.Name = studentVM.Name;
                student.EnrollmentDate = studentVM.EnrollmentDate;

                //adding photo to the object
                if (studentVM.Photo != null)
                {
                    student.Photo = ImageConverter.ByteArrayFromPostedFile(studentVM.Photo);
                }
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentVM);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            Mapper.CreateMap<Student, StudentViewModel>().ForMember(x => x.Photo, opt => opt.Ignore());
            // AUTOMAPPER
            var studentVM = Mapper.Map<StudentViewModel>(student);
            studentVM.PhotoDB = student.Photo;

            return View(studentVM);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,EnrollmentDate,Photo")] StudentViewModel studentVM)
        {
            if (ModelState.IsValid)
            {
                Student student = db.Students.Find(studentVM.Id);
                if (studentVM != null && studentVM.Photo != null)
                {
                    student.Photo = ImageConverter.ByteArrayFromPostedFile(studentVM.Photo);
                }
                student.Name = studentVM.Name;
                student.EnrollmentDate = studentVM.EnrollmentDate;

                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentVM);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
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
