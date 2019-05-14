using SitioPersonal.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SitioPersonal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //register bundles
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //to redirect
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
           "Default", // Route name
           "{controller}/{action}/{id}", // URL with parameters
           new { controller = "Home", action = "Home", id = UrlParameter.Optional } //Parameter defaults
           );
        }
    }
}
