using System.Collections.Generic;
using System.Web.Mvc;
using Nop.Admin.Controllers;
using CommonController = Nop.Web.Controllers.CommonController;

namespace Nop.Plugins.MyStore.Filters
{
    public class NopFilterProvider: IFilterProvider
    {
        public IEnumerable<Filter> GetFilters(ControllerContext controllerContext, ActionDescriptor actionDescriptor)
        {

            //ContactUs
            if ((actionDescriptor.ControllerDescriptor.ControllerType == typeof(CommonController))
                   && (actionDescriptor.ActionName.Equals("ContactUs"))
                   && (controllerContext.HttpContext.Request.HttpMethod == "POST"))
            {
                return new[]
                    {
                        new Filter(new ContactUsFilterAttribute(), FilterScope.Action, null)
                    };
            }



            //Admin Product Extended fields

            if ((actionDescriptor.ControllerDescriptor.ControllerType == typeof(ProductController))
               && (actionDescriptor.ActionName.Equals("Edit"))
               && (controllerContext.HttpContext.Request.HttpMethod == "POST"))
            {
                return new[]
                    {
                        new Filter(new ExtendedFieldsAdminFilterAttribute(), FilterScope.Action, null)
                    };
            }

            //Front Product Extended fields
            if ((actionDescriptor.ControllerDescriptor.ControllerType == typeof(Nop.Web.Controllers.ProductController))
              && (actionDescriptor.ActionName.Equals("ProductDetails"))
              && (controllerContext.HttpContext.Request.HttpMethod == "GET"))
            {
                return new[]
                    {
                        new Filter(new ExtendedFieldsPublicFilterAttribute(), FilterScope.Action, null)
                    };
            }


            return new Filter[] { };
        }
    }
}