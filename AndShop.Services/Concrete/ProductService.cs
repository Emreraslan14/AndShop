using AndShop.Core.Entities;
using Andshop.DataAccess.Repos.Abstract;
using AndShop.Services.Abstract;

namespace AndShop.Services.Concrete
{
    public class ProductService : GenericService<Product>, IProductService
    {
        public ProductService(IGenericRepo<Product> repo) : base(repo)
        {

        }
    }
}
