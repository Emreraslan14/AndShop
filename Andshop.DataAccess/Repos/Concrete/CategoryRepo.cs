using AndShop.Core.Entities;
using Andshop.DataAccess.Contexts.EfCoreApp;
using Andshop.DataAccess.Repos.Abstract;

namespace Andshop.DataAccess.Repos.Concrete
{
    public class CategoryRepo : GenericRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(AppDbContext ctx) : base(ctx)
        {
        }
    }
}
