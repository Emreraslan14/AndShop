using AndShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Andshop.DataAccess.Configuration.Mappings
{
    public class RoleClaimConf : IEntityTypeConfiguration<RoleClaim>
    {
        public void Configure(EntityTypeBuilder<RoleClaim> b)
        {
            b.HasKey(rc => rc.Id);
            b.Property(x => x.Id).ValueGeneratedOnAdd();
            b.ToTable("RoleClaims");
        }
    }
}
