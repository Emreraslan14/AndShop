using AndShop.Core.Entities;
using AndShop.Services.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AndShop.Web.Areas.VendorPanel.Controllers
{
    [Area("VendorPanel")]
    public class ProfileController : Controller
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly UserManager<User> _userManager;
        private readonly IVendorService _vendorService;

        public ProfileController(IHttpContextAccessor contextAccessor, UserManager<User> userManager, IVendorService vendorService)
        {
            _contextAccessor = contextAccessor;
            _userManager = userManager;
            _vendorService = vendorService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (_contextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                var name = _contextAccessor.HttpContext.User.Identity.Name;

                var user = await _userManager.FindByNameAsync(name);

                var vendor = _vendorService.Get(x => x.UserId == user.Id);

                if (vendor == null)
                {
                    return NotFound();
                }

                return View(vendor);
            }

            return NotFound();
        }
    }
}
