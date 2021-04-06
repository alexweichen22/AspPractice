 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XHomeInventory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Home Inventory's Index Page Description(viewbag.msg)";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Home Inventory's About Page Description(viewbag.msg)";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Home Inventory' contact message (viewbag.msg)";

            return View();
        }
    }
}