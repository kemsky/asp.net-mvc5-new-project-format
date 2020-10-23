using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Application.Web;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace Application.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            try
            {
                AreaRegistration.RegisterAllAreas();

                GlobalConfiguration.Configure(c => c.ConfigureWebApi());

                RouteTable.Routes.ConfigureApplicationRoutes();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Startup Error: {e.Message}");
                throw;
            }
        }
    }
}