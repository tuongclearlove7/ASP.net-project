using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace web_profile_MVC_VS2019
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
                routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           

                routes.MapRoute(

                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

                

                routes.MapRoute(

                    name: "News",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "News", action = "Index", id = UrlParameter.Optional }
               );

                routes.MapRoute(

                    name: "Documentation",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Documentation", action = "Index", id = UrlParameter.Optional }
                );
        }
    }
}
