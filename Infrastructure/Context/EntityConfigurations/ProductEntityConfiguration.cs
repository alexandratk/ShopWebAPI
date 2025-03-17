using Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.EntityConfigurations
{
    internal class ProductEntityConfiguration : BaseEntityConfiguration<Product>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasMany(l => l.PurchaseItems)
                .WithOne(m => m.Product)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
