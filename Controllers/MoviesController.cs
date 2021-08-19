
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCSample.Models;

namespace MVCSample.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            //creating an instance of movie class
            var movie = new Movie()
            {
                Name = "Happy"
            };
            
            return View(movie);
        }

       
    }
}