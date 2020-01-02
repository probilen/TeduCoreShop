using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCoreTedu.Data.EF.Extensions;
using ShopCoreTedu.Data.Entities;

namespace ShopCoreTedu.Data.EF.Configurations
{
    public class BlogTagConfiguration : DbEntityConfiguration<BlogTag>
    {
        public override void Configure(EntityTypeBuilder<BlogTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            .HasColumnType("varchar(50)");
            // etc.
        }
    }
}