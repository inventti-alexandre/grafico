using ChartTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new ChartViewModel
            {
                ValuesX = "#Jan#, #Fev#, #Mar#, #Abr#, #Mai#, #Jun#",
                ValuesY = "10.0, 20.0, 12.0, 18.0, 26.0, 40.0"
            };

            return View(model);
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