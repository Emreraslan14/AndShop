using AndShop.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AndShop.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class AddressController : Controller
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly UserManager<User> _userManager;

        public AddressController(IHttpContextAccessor contextAccessor, UserManager<User> userManager)
        {
            _contextAccessor = contextAccessor;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (_contextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                var name = _contextAccessor.HttpContext.User.Identity.Name;

                var user = await _userManager.FindByNameAsync(name);

                return View(user);
            }

            return NotFound();
        }
    }
}
