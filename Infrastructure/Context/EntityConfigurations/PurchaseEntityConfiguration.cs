using Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.EntityConfigurations
{
    internal class PurchaseEntityConfiguration : BaseEntityConfiguration<Purchase>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Purchase> builder)
        {
            builder
                .HasMany(l => l.PurchaseItems)
                .WithOne(m => m.Purchase)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
