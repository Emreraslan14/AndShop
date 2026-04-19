using AndShop.Core.Entities;
using AndShop.Services.Settings;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace AndShop.Services.Concrete
{
    public class DataSeedingService
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly UserManager<User> _userManager;
        private readonly AdminSettings _adminSettings;

        public DataSeedingService(RoleManager<Role> roleManager, UserManager<User> userManager, IOptions<AdminSettings> adminSettings)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _adminSettings = adminSettings.Value;
        }

        public async Task SeedRolesAsync()
        {
            var roles = new[] { "Admin", "Vendor", "Member" };
            foreach (var roleName in roles)
            {
                if (!await _roleManager.RoleExistsAsync(roleName))
                {
                    await _roleManager.CreateAsync(new Role { Name = roleName });
                }
            }
        }

        public async Task SeedAdminUserAsync()
        {
            if (await _userManager.FindByEmailAsync(_adminSettings.Email) == null)
            {
                var user = new User
                {
                    Name = "Admin",
                    UserName = _adminSettings.Email,
                    Email = _adminSettings.Email,
                    Address = "AdminAdress",
                    Surname = "Admin",
                    EmailConfirmed = true
                };

                await _userManager.CreateAsync(user, _adminSettings.Password);
                await _userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
