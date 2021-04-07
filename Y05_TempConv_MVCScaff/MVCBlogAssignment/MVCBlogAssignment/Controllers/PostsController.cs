using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MVCBlogAssignment.Helpers;
using MVCBlogAssignment.Models;

namespace MVCBlogAssignment.Controllers
{
    public class PostsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: Posts
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        public ActionResult OnlyPublic()
        {
            var posts = db.Posts.Where(p => p.PostedOn.HasValue).OrderByDescending(p => p.PostedOn).ToList();
            return View("OnlyPublic", posts);
        }

        public ActionResult Full(int id)
        {
            var post = db.Posts.Include(p => p.Comments).Where(p => p.Id == id).FirstOrDefault();
            return View("FullPost", post);
        }


        // GET: Posts/Details/5
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Include(p => p.Comments).Where(p => p.Id == id).FirstOrDefault();
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // GET: Posts/Create
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Create([Bind(Include = "Title,Content,PostedOn")] CreatePostViewModel createPostViewModel)
        {
            if (ModelState.IsValid)
            {
                Post post = new Post();
                post.CreatedOn = DateTime.Now;
                post.UpdatedOn = DateTime.Now;
                post.Title = createPostViewModel.Title;
                post.Content = createPostViewModel.Content;
                post.PostedOn = createPostViewModel.PostedOn;
                post.UserFullName = UserHelper.GetUserName(db.Users, User.Identity);
                //string userId = User.Identity.GetUserId();
                //ApplicationUser user = db.Users.FirstOrDefault(x => x.Id == userId);
                //post.UserFullName = user.FullName;
                
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(createPostViewModel);
        }

        // GET: Posts/Edit/5
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Edit( Post post)
        {
            if (ModelState.IsValid)
            {
                Post postInDb = db.Posts.FirstOrDefault(p => p.Id == post.Id);
                postInDb.PostedOn = post.PostedOn;
                postInDb.Title = post.Title;
                postInDb.Content = post.Content;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(post);
        }

        // GET: Posts/Delete/5
        [Authorize(Roles = RoleName.CanManage)]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Posts/Delete/5
        [Authorize(Roles = RoleName.CanManage)]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Posts.Find(id);
            db.Posts.Remove(post);
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
