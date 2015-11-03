using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;

namespace Nop.Plugins.MyStore.Models.Product
{
    public class ProductExtendedFieldsModel: BaseNopEntityModel
    {
        [NopResourceDisplayName("Uteam.MyStore.Product.Heading")]
        public  string Heading { get; set; }
        [NopResourceDisplayName("Uteam.MyStore.Product.MyCheck")]
        public bool MyCheck { get; set; }
    }
}