using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace _3_WebApi_Custom_Route.App_Start
{
    public class CustomRouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapHttpRoute(
                "api_category_filter",
                "api/filter/{categoryType}",
                new { controller = "category", categoryType = "all" });

            routes.MapHttpRoute(
                "api_default",
                "api/{controller}/{action}/{id}",
                new { id = RouteParameter.Optional });
        }
    }
}