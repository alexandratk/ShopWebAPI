using Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.EntityConfigurations
{
    internal class CustomerEntityConfiguration : BaseEntityConfiguration<Customer>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasMany(l => l.Purchases)
                .WithOne(m => m.Customer)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
