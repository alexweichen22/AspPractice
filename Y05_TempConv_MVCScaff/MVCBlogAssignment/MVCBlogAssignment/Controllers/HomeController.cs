using MVCBlogAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogAssignment.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var controler = new PostsController();
            controler.ControllerContext = new ControllerContext(this.ControllerContext.RequestContext, controler);
            return controler.OnlyPublic();
        }


    }
}