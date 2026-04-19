using AndShop.Core.Entities;
using Andshop.DataAccess.Contexts.EfCoreApp;
using Andshop.DataAccess.Repos.Abstract;

namespace Andshop.DataAccess.Repos.Concrete
{
    public class OrderRepo : GenericRepo<Order>, IOrderRepo
    {
        public OrderRepo(AppDbContext ctx) : base(ctx)
        {
        }
    }
}
