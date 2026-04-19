using Microsoft.AspNetCore.Mvc;

namespace AndShop.Web.Areas.VendorPanel.Controllers
{
    [Area("VendorPanel")]
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
