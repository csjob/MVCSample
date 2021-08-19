
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

            //  return View(movie);
            // return Content("Helloo");
            //  return HttpNotFound();
            // return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name", age=101 });
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("Id is : " + id);
        }

        // -> /movies

        //this is for making parameters as optional, if we dont pass any parameter
        //it'll display the below default values.
        //if we pass any parameter then it'll display that data.
        //https://localhost:44350/movies/index?pageindex=10&sortby=new

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 100;
            }
            if (string.IsNullOrEmpty(sortBy))
            {
                sortBy = "Default name";
            }
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }

        //for mvc attribute route
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate( int year, int month)
        {
            return Content("Release year and month : " +year + "/" + month);
        }

        
    }
}