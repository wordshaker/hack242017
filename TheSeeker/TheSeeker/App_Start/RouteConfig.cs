using System.Web.Mvc;
using System.Web.Routing;

namespace TheSeeker
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );

            routes.MapRoute(
                name: "Congrats",
                url: "{action}/{id}",
                defaults: new { action = "Congrats", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "SignUp",
                url: "{action}/{id}",
                defaults: new { action = "SignUp", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Confirmation",
                url: "{action}/{id}",
                defaults: new { action = "Confirmation", id = UrlParameter.Optional }
            );
        }
    }
}
