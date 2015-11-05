using System.Web.Mvc;
using System.Web.Routing;

namespace DynamicRouteExample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CategoryRoute",
                url: "{category}/{location}",
                defaults: new { controller = "Category", action = "Index", location = UrlParameter.Optional },
                constraints: new { category = new CategoryRouteConstraint() }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}