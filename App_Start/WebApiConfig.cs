using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MvcApp_0074
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "amikom/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
