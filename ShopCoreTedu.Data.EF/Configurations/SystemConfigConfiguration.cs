using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCoreTedu.Data.EF.Extensions;
using ShopCoreTedu.Data.Entities;

namespace ShopCoreTedu.Data.EF.Configurations
{
    class SystemConfigConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
