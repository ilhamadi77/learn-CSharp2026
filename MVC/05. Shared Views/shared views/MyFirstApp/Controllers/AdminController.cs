using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Contact()
        {
            // passing data dynamic to shared views
            ViewBag.TollFree = "456-456-456";
            return View();
        }
    }
}


