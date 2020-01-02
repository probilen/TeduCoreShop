using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCoreTedu.Data.EF.Extensions;
using ShopCoreTedu.Data.Entities;

namespace ShopCoreTedu.Data.EF.Configurations
{
    public class FunctionConfiguration : DbEntityConfiguration<Function>
    {
        public override void Configure(EntityTypeBuilder<Function> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).IsRequired()
            .HasColumnType("varchar(128)");
            // etc.
        }
    }
}
