using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nop.Plugins.MyStore.Models.ContactUs;

namespace Nop.Plugins.MyStore.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult ContactUs()
        {
            var model=new ContactUsModel();
            return View(model);
        }
    }
}