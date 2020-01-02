using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCoreTedu.Data.EF.Extensions;
using ShopCoreTedu.Data.Entities;

namespace ShopCoreTedu.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
            // etc.
        }
    }
}
