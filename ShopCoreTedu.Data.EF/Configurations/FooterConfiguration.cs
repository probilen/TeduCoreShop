using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCoreTedu.Data.EF.Extensions;
using ShopCoreTedu.Data.Entities;

namespace ShopCoreTedu.Data.EF.Configurations
{
    public class FooterConfiguration : DbEntityConfiguration<Footer>
    {
        public override void Configure(EntityTypeBuilder<Footer> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255)
                .HasColumnType("varchar(255)").IsRequired();
            // etc.
        }
    }
}
