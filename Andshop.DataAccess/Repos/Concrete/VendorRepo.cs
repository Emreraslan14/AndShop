using AndShop.Core.Entities;
using Andshop.DataAccess.Contexts.EfCoreApp;
using Andshop.DataAccess.Repos.Abstract;

namespace Andshop.DataAccess.Repos.Concrete
{
    public class VendorRepo : GenericRepo<Vendor>, IVendorRepo
    {
        public VendorRepo(AppDbContext ctx) : base(ctx)
        {

        }


    }
}
