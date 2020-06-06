using _3_WebApi_Custom_Route.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace _3_WebApi_Custom_Route
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            CustomRouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
