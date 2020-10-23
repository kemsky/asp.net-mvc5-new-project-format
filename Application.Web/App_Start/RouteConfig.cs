using System.Web.Mvc;
using System.Web.Routing;

namespace Application.Web
{
    public static class RouteConfig
    {
        public static void ConfigureApplicationRoutes(this RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Index", "", new {controller = "Default", action = "Index", id = UrlParameter.Optional});
        }
    }
}