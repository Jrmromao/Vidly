using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            //
            // use attribute routing - this is old to do it!!
            //
////start old way
//            //routes goes from specific to most generic
//            routes.MapRoute(
//                "MoviesByReleasedDate",                                  // name of the route
//                "movies/released/{year}/{month}",                        // URL
//                new {Controller = "Movies", action = "ByReleasedDate"},  // anonymous object
//                new {year = @"\d{4}", month = @"\d{2}"});                // format the parameters in the URL
//            //if we want to contain the year to 2015 to 2016
//            // we cab us a regular expression as: @"2015|2016" - user the logical operator for 'OR'
//// end old way

 //// new way
    
            routes.MapMvcAttributeRoutes();
 //// end new way 



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
