using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nop.Core.Infrastructure;
using Nop.Services.Catalog;
using Nop.Services.Common;

namespace Nop.Plugins.MyStore.Filters
{
    public class ExtendedFieldsAdminFilterAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var genericAttributeService = EngineContext.Current.Resolve<IGenericAttributeService>();
            var id = int.Parse(filterContext.HttpContext.Request.Form["Id"]);
            var myCheck = bool.Parse(filterContext.HttpContext.Request.Form["MyCheck"].Split(',')[0]);
            var heading = filterContext.HttpContext.Request.Form["Heading"];
            var product = EngineContext.Current.Resolve<IProductService>().GetProductById(id);
            if (product != null)
            {
                genericAttributeService.SaveAttribute(product, "Heading", heading);
                genericAttributeService.SaveAttribute(product, "MyCheck", myCheck);
            }
        }
    }
}