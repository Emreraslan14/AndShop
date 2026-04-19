using Microsoft.AspNetCore.Identity;

namespace AndShop.Core.Entities
{
	public class User : IdentityUser<string>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public List<Order> Orders { get; set; }
        public Vendor Vendor { get; set; }
    }
}
