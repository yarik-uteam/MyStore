using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nop.Plugins.MyStore.Models.ContactUs
{
    public class ContactUsModel: Web.Models.Common.ContactUsModel
    {
        public string Address { get; set; }
        public string City { get; set; }
    }
}