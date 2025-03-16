using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DoAn3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["songuoitruycap"] = 1021;
        }
        protected void Session_Start()
        {
            Application["songuoitruycap"] = int.Parse(Application["songuoitruycap"].ToString())+1;
            Session["giohang"] = null;

        }
        protected void Session_End()
        {
            Application["songuoitruycap"] = int.Parse(Application["songuoitruycap"].ToString())-1;
            Session["giohang"] = null;


        }
    }
}
