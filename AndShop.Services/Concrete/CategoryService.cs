using AndShop.Core.Entities;
using Andshop.DataAccess.Repos.Abstract;
using AndShop.Services.Abstract;

namespace AndShop.Services.Concrete
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        public CategoryService(IGenericRepo<Category> repo) : base(repo)
        {

        }
    }
}
