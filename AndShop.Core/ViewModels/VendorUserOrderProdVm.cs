using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndShop.Core.Entities;

namespace AndShop.Core.ViewModels
{
    public class VendorUserOrderProdVm
    {
        public Order Order { get; set; }
        public Vendor Vendor { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
