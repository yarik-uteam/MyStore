using System.Web.Mvc;
using Nop.Core.Infrastructure;
using Nop.Services.Catalog;
using Nop.Services.Common;
using Nop.Web.Models.Catalog;

namespace Nop.Plugins.MyStore.Filters
{
    public class ExtendedFieldsPublicFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var result = filterContext.Result as ViewResultBase;
            var model = result?.Model as ProductDetailsModel;
            if (model == null) return;
            var productService = EngineContext.Current.Resolve<IProductService>();
            var product = productService.GetProductById(model.Id);
            if (product == null) return;
            var heading = product.GetAttribute<string>("Heading");
            model.Name = heading ?? model.Name;

            var myCheck = product.GetAttribute<bool>("MyCheck");
            model.CustomProperties.Add("MyCheck", myCheck);
        }
    }
}