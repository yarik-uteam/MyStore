using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Nop.Web.Framework.Mvc.Routes;

namespace Nop.Plugins.MyStore.Infrastructure
{
    public class RouteProvider: IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            ViewEngines.Engines.Insert(0, new PluginViewEngine());
            //contact us example
           
           var  route = routes.MapRoute("ContactUsCustom","contactus",
            new { controller = "ContactUs", action = "ContactUs" },
            namespaces: new[] { "Nop.Plugins.MyStore.Controllers" }
            );
            routes.Remove(route);
            routes.Insert(0, route);

 

              route = routes.MapRoute("ProductExtendedFields",
              "Admin/Category/ProductExtendedFields/{productId}",
              new { controller = "ExtendedFields", action = "ProductExtendedFields" },
              new[] { "Nop.Plugins.MyStore.Controllers" }
              );

            route.DataTokens.Add("area", "admin");
            routes.Remove(route);
            routes.Insert(0, route);
        }

        public int Priority => 0;
    }
}