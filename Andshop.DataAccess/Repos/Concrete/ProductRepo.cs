using AndShop.Core.Entities;
using Andshop.DataAccess.Contexts.EfCoreApp;
using Andshop.DataAccess.Repos.Abstract;

namespace Andshop.DataAccess.Repos.Concrete
{
    public class ProductRepo : GenericRepo<Product>, IProductRepo
    {
        public ProductRepo(AppDbContext ctx) : base(ctx)
        {
        }
    }
}
