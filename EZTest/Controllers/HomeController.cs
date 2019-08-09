using EZTest.Context;
using EZTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EZTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EZTestDbContext db = new EZTestDbContext();
            db.Adresses.Find(1);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}