using Microsoft.AspNetCore.Mvc;

namespace AndShop.Web.Areas.VendorPanel.Controllers
{
    [Area("VendorPanel")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
