using System;
using System.IO;
using System.Web.Mvc;
using System.Xml.Schema;
using ImageResizer;
using Nop.Web.Models.Common;

namespace Nop.Plugins.MyStore.Filters
{
    public class ContactUsFilterAttribute: ActionFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            var model = filterContext.Controller.ViewData.Model as ContactUsModel;
            if (model != null && model.SuccessfullySent == true)
            {
                var message = $"Name: {model.FullName}, Email: {model.Email}, Message: {model.Enquiry}";
               File.WriteAllText($"{filterContext.HttpContext.Server.MapPath("~/App_Data/ContactUs")}\\{DateTime.Now.Ticks.ToString()}.txt", message);
            }
        }
      
    }
}