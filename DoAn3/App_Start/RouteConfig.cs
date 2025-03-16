using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DoAn3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "Category",
               url: "danh-muc-san-pham/{id}",
               defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "DoAn3",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );

            routes.MapRoute(
                name: "Admin",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "QLDienthoai", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
