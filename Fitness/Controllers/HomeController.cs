using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fitness.Models;

namespace Fitness.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            //var log  = new List<WorkoutLogInfo>();
            ViewBag.log = DataRetrieval.LoadLog();
            ViewBag.lift = StrengthInfo.GetLifts();
            ViewBag.metcon = MetconInfo.GetMetcons();
            //workoutLog.Add(Convert.ToDateTime("12/16/2016"), "BackSquat", "Fran");
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