using System.Web.Mvc;
using System.Web.Routing;

namespace TheSeeker
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );

            routes.MapRoute(
                name: "Congrats",
                url: "congrats",
                defaults: new {controller = "Home", action = "Congrats" }
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
