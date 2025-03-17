using Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.EntityConfigurations
{
    internal class ProductCategoryEntityConfiguration : BaseEntityConfiguration<ProductCategory>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<ProductCategory> builder)
        {
            builder
                .HasMany(l => l.Products)
                .WithOne(m => m.ProductCategory)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
