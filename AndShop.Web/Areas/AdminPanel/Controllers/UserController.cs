using AndShop.Core.Entities;
using AndShop.Services.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AndShop.Web.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class UserController : Controller
    {
        private readonly UserService _userService;

		public UserController(UserService userService)
		{
			_userService = userService;
		}

		public async Task<IActionResult> Index()
        {
            List<User> users = await _userService.GetAll();
            return View(users);
        }

        public async Task<IActionResult> Delete(string id) 
        {
            var result = await _userService.DeleteUser(id);
            if(result)
                return RedirectToAction("Index", "User", new { area = "AdminPanel" });
            else
                return NotFound();
        }
    }
}
