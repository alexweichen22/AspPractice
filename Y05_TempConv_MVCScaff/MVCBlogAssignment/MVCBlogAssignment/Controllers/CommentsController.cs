using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCBlogAssignment.Helpers;
using MVCBlogAssignment.Models;

namespace MVCBlogAssignment.Controllers
{
    public class CommentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Comments
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Index(int? postId)
        {
            List<Comment> comments = null;
            if (postId.HasValue)
                comments = db.Comments.Include(c => c.Post).Where(c => c.PostId == postId).ToList();
            else
                comments = db.Comments.Include(c => c.Post).OrderByDescending(c => c.CreatedOn).ToList();
            return View(comments.ToList());
        }

        // GET: Comments/Details/5
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.Include(c => c.Post).Where(c => c.Id == id).FirstOrDefault();
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        [HttpPost]
        public ActionResult Add(AddCommentViewModel addCommentViewModel)
        {
            if (ModelState.IsValid)
            {
                Comment comment = new Comment();
                comment.PostId = addCommentViewModel.postId;
                comment.CreatedOn = DateTime.Now;
                comment.UpdatedOn = DateTime.Now;
                comment.UserFullName = UserHelper.GetUserName(db.Users, User.Identity);
                comment.Content = addCommentViewModel.Content;
                db.Comments.Add(comment);
                db.SaveChanges();
                return View("CommentConfirmation", addCommentViewModel);
            }
            return new EmptyResult();
        }

        // GET: Comments/Create
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Create()
        {
            ViewBag.PostId = new SelectList(db.Posts, "Id", "Title");
            return View();
        }

        // POST: Comments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Create([Bind(Include = "Id,Content,CreatedOn,UpdatedOn,UserFullName,PostId,IsPublished")] Comment comment)
        {
            if (ModelState.IsValid)
            {

                db.Comments.Add(comment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PostId = new SelectList(db.Posts, "Id", "Title", comment.PostId);
            return View(comment);
        }

        // GET: Comments/Edit/5
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            ViewBag.PostId = new SelectList(db.Posts, "Id", "Title", comment.PostId);
            return View(comment);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Edit([Bind(Include = "Id,Content,CreatedOn,UpdatedOn,UserFullName,PostId,IsPublished")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                Comment commentInDb = db.Comments.FirstOrDefault(c => c.Id == comment.Id);
                commentInDb.Content = comment.Content;
                commentInDb.UpdatedOn = comment.UpdatedOn;
                commentInDb.IsPublished = comment.IsPublished;

                //db.Entry(comment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PostId = new SelectList(db.Posts, "Id", "Title", comment.PostId);
            return View(comment);
        }

        // GET: Comments/Delete/5
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // POST: Comments/Delete/5
        [Authorize(Roles = RoleName.CanManage)]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comment comment = db.Comments.Find(id);
            db.Comments.Remove(comment);
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
