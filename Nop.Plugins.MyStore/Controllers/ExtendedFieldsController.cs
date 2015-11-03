using System.Web.Mvc;
using Nop.Admin.Controllers;
using Nop.Plugins.MyStore.Models.Product;
using Nop.Services.Catalog;
using Nop.Services.Common;

namespace Nop.Plugins.MyStore.Controllers
{
    public class ExtendedFieldsController : BaseAdminController
    {
        private readonly IProductService _productService;

        public ExtendedFieldsController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult ProductExtendedFields(int productId)
        {
            var model = new ProductExtendedFieldsModel();
            var product = _productService.GetProductById(productId);

            if (product != null)
            {
                model.Heading = product.GetAttribute<string>("Heading");
                model.MyCheck = product.GetAttribute<bool>("MyCheck");
            }
            return View(model);
        }
    }
}