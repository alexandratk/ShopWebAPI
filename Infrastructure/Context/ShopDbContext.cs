using System.Reflection;
using Domain.Core.Entities;
using Domain.Core.Entities.Base;
using Infrastructure.Context.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.Context
{
    public class ShopDbContext : DbContext
    {
        public const string CreatedOn = "CreatedOn";

        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CustomerEntityConfiguration());
            builder.ApplyConfiguration(new ProductEntityConfiguration());
            builder.ApplyConfiguration(new ProductCategoryEntityConfiguration());
            builder.ApplyConfiguration(new PurchaseEntityConfiguration());

            ConfigureCreatedOnProperty(builder);
        }

        private static void ConfigureCreatedOnProperty(ModelBuilder builder)
        {
            List<Type> modelTypes = typeof(ShopDbContext).GetProperties()
                .Where(x => x.PropertyType.IsGenericType && x.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
                .Select(x => x.PropertyType.GetGenericArguments().First())
                .ToList();

            foreach (Type modelType in modelTypes)
            {
                PropertyInfo key = modelType.GetProperties().FirstOrDefault(x => x.Name.Equals(CreatedOn, StringComparison.InvariantCulture));
                if (key == null)
                {
                    continue;
                }

                builder.Entity(modelType)
                            .Property(key.Name)
                            .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            }
        }

        public override int SaveChanges()
        {
            SetUtcFormat();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetUtcFormat();
            await base.SaveChangesAsync(cancellationToken);

            try
            {
                SetUtcFormat();
                return await base.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void SetUtcFormat()
        {
            IEnumerable<EntityEntry> createdEntries = ChangeTracker.Entries()
               .Where(x => x.State == EntityState.Added);

            DateTime now = DateTime.UtcNow;
            foreach (EntityEntry entry in createdEntries)
            {
                if (entry.Entity is not BaseEntity entity)
                {
                    continue;
                }

                entity.CreatedOn = now;
            }
        }
    }
}
