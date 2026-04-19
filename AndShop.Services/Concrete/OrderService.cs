using AndShop.Core.Entities;
using Andshop.DataAccess.Repos.Abstract;
using AndShop.Services.Abstract;

namespace AndShop.Services.Concrete
{
    public class OrderService : GenericService<Order>, IOrderService
    {
        public OrderService(IGenericRepo<Order> repo) : base(repo)
        {
        }
    }
}
