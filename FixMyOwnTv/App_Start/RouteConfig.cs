using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FixMyOwnTv
{
    public class RouteConfig
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.RouteExistingFiles = false;

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // THIS IS HANDLED IN WEB.CONFIG REWRITE RULES
            //routes.MapRoute(
            //    name: "Legacy (QueryString)",
            //    url: "",
            //    defaults: new { controller = "Book", action = "Default", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Exception",
                url: "Error/{action}",
                defaults: new { controller = "Error", action = "Global" }
            );

            routes.MapRoute(
                name: "Article/Article & Title",
                url: "Article/{article}/{title}",
                defaults: new { controller = "Book", action = "Default", article = UrlParameter.Optional, title = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Article/Article",
                url: "Article/{article}",
                defaults: new { controller = "Book", action = "Default", article = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Article & Title",
                url: "{article}/{title}",
                defaults: new { controller = "Book", action = "Default", article = UrlParameter.Optional, title = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Article",
                url: "{article}",
                defaults: new { controller = "Book", action = "Default", article = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "default",
                url: "",
                defaults: new { controller = "Book", action = "Default" }
            );
        }
    }
}