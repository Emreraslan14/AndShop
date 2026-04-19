using AndShop.Core.Entities;
using Andshop.DataAccess.Contexts.EfCoreApp;
using Microsoft.EntityFrameworkCore;

namespace AndShop.Services.Concrete
{
    public class ProductOrderService
    {
        private readonly AppDbContext _ctx;

        public ProductOrderService(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public ProductOrder GetByOrderId(int id)
        {
            ProductOrder prdOrd = _ctx.Set<ProductOrder>().SingleOrDefault(x => x.OrderId == id);
            return prdOrd;
        }

        public int Insert (ProductOrder prdOrd)
        {
            _ctx.Entry(prdOrd).State = EntityState.Added;
            return _ctx.SaveChanges();
        }
    }
}
