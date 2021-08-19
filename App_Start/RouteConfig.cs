using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCSample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /* // this is custom route 
             //for calling   /movies/released/2016/02
             routes.MapRoute(
                 name: "MoviesByreleaseDate",
                 url: "movies/released/{year}/{month}",
                 new { controller = "Movies", action = "ByReleaseDate"},
                 new {year = @"\d{4}", month = @"\d{2}"}

                 );
            */

            routes.MapMvcAttributeRoutes();

            //we need to add this before default because the order of the route matters


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
