using MVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            var about = new About()
            {
                AboutMe = "Its me Job"
            };
            return View(about);
        }

        public ActionResult AboutPage()
        {
            var about = new About()
            {
                AboutMe = "Its me don from about"
            };
            return View(about);
        }

        public ActionResult HelloPage()
        {
            var hello = new Hello()
            {
                HelloName = "it is hello class"
            };
            return View(hello);
        }
    }
}