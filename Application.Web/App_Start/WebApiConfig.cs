using System.Web.Http;

namespace Application.Web
{
    public static class WebApiConfig
    {
        public static void ConfigureWebApi(this HttpConfiguration config)
        {
            config.EnableCors();

            config.SuppressDefaultHostAuthentication();

            config.MapHttpAttributeRoutes();
        }
    }
}