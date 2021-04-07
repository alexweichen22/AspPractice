using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MVCScaffolding.Helper;
using MVCScaffolding.Models;
using MVCScaffolding.ViewModels;

namespace MVCScaffolding.Controllers
{
    public class StudentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
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
        [ValidateAntiForgeryToken] //AntiForgery means nobody can steal the session
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
            //var StudentModel = new StudentViewModel();
            //StudentModel.Name = student.Name;
            //is it a good idea for no value put every value from A to B ?
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
        public ActionResult Edit(StudentViewModel studentVM)
        {
            if (ModelState.IsValid) //no validation error
            {
                Student student = db.Students.Find(studentVM.Id);
                if(studentVM != null && studentVM.Photo != null)
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
