using AndShop.Core.Entities;
using Andshop.DataAccess.Repos.Abstract;
using AndShop.Services.Abstract;

namespace AndShop.Services.Concrete
{
    public class VendorService : GenericService<Vendor>, IVendorService
    {
        public VendorService(IGenericRepo<Vendor> repo) : base(repo)
        {

        }
    }
}
