using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;

namespace Application.Web
{
    public class MvcApplication : HttpApplication
    {
        /// <summary>
        /// Called once per Application Domain
        /// </summary>
        protected void Application_Start()
        {
            Trace.WriteLine("Application_Start");
            MvcHandler.DisableMvcResponseHeader = true;
        }

        /// <summary>
        /// Called once per Application Domain
        /// </summary>
        protected void Application_End()
        {
            Trace.WriteLine("Application_End");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
        }
    }
}