using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace stateexamples
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Application["AppCount"] = 0;
            Application["SessionCount"] = 0;
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        void Session_Start(object sender, EventArgs e)
        {
            Application["SessionCount"] = (int)Application["SessionCount"] + 1;

        }
        void Session_End(object sender, EventArgs e)
        {
            Application["SessionCount"] = (int)Application["SessionCount"] - 1;
        }
    }
}