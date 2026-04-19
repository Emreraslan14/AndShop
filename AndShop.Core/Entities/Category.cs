using AndShop.Core.Entities.BaseEntity;

namespace AndShop.Core.Entities
{
    public class Category : IEntity
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
