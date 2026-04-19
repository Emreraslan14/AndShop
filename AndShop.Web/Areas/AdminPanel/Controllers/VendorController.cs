using AndShop.Core.Entities;
using AndShop.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AndShop.Web.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class VendorController : Controller
    {
        private readonly IVendorService _vendorService;

		public VendorController(IVendorService vendorService)
		{
			_vendorService = vendorService;
		}

		public IActionResult Index()
        {
            List<Vendor> vendorList = _vendorService.GetAll();
            return View(vendorList);
        }

        public IActionResult Delete(int id)
        {
            var vendor = _vendorService.GetById(id);
            _vendorService.Delete(vendor);

            return RedirectToAction("Index", "Vendor", new {area="AdminPanel"});
        }
    }
}
