using AndShop.Core.Entities;
using AndShop.Core.ViewModels;
using AndShop.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AndShop.Web.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IVendorService _vendorService;

		public ProductController(IProductService productService, IVendorService vendorService)
		{
			_productService = productService;
			_vendorService = vendorService;
		}

		public IActionResult Index()
        {
            ProductVendorVm vm = new ProductVendorVm();

            List<Vendor> vendors = _vendorService.GetAll();
            List<Product> products = _productService.GetAll();

            vm.Vendors = vendors;
            vm.Products = products;

            return View(vm);
        }

        public IActionResult Delete(int id)
        {
            Product prod = _productService.GetById(id);
            _productService.Delete(prod);
            return RedirectToAction("Index", "Product", new { area = "AdminPanel" });
        }
    }
}
