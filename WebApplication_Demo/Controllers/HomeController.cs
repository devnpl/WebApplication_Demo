using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_Demo.Controllers
{
    public class HomeController : Controller


    {
        public ActionResult Dev()
        {
            ViewBag.Message = "This is Dev view from Controller";
            return View();

        }

        public ActionResult Archu()
        {
            ViewBag.title = "This page is dedicated to Archana Khatiwada";
            return View();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "This is me Edited";

            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.Now it will be edited";

            ViewBag.Name = "Dev";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Allusers()
        {
         ViewBag.Message = "This is the new allusers";

            return View();
        }

        public ActionResult TestAction()
        {
            ViewBag.Message="This is the test Action";
            return View();
        }
    }
}