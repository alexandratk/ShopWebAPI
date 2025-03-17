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

            SeedData(builder);

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

        private static void SeedData(ModelBuilder builder) 
        {
            var random = new Random();
            var now = DateTime.UtcNow;

            var categories = new List<ProductCategory>();
            for (int i = 0; i < 10; i++)
            {
                categories.Add(new ProductCategory($"Category {i + 1}")
                {
                    Id = Guid.NewGuid(),
                    CreatedOn = now.AddDays(-i * 2)
                });
            }

            var products = new List<Product>();
            for (int i = 0; i < 20; i++)
            {
                var category = categories[random.Next(categories.Count)];
                products.Add(new Product($"Product {i + 1}", category.Id, $"ART-{i + 1:D3}", random.Next(10, 1000))
                {
                    Id = Guid.NewGuid(),
                    CreatedOn = now.AddDays(-i * 1.5)
                });
            }

            var customers = new List<Customer>
            {
                new Customer("John Doe", new DateTime(1990, 5, 15), now.AddDays(-30)) { Id = Guid.NewGuid(), CreatedOn = now.AddDays(-30) },
                new Customer("Alice Smith", new DateTime(1985, 10, 22), now.AddDays(-25)) { Id = Guid.NewGuid(), CreatedOn = now.AddDays(-25) },
                new Customer("Robert Johnson", new DateTime(1995, 8, 3), now.AddDays(-20)) { Id = Guid.NewGuid(), CreatedOn = now.AddDays(-20) },
                new Customer("Emily Davis", new DateTime(2000, 2, 18), now.AddDays(-15)) { Id = Guid.NewGuid(), CreatedOn = now.AddDays(-15) },
                new Customer("Michael Brown", new DateTime(1992, 6, 30), now.AddDays(-10)) { Id = Guid.NewGuid(), CreatedOn = now.AddDays(-10) }
            };

            var purchases = new List<Purchase>();
            for (int i = 0; i < 30; i++)
            {
                var customer = customers[random.Next(customers.Count)];
                purchases.Add(new Purchase(random.Next(50, 2000), customer.Id)
                {
                    Id = Guid.NewGuid(),
                    CreatedOn = now.AddDays(-i * 1.2)
                });
            }

            var purchaseItems = new List<PurchaseItem>();
            int purchaseItemCount = 0;
            foreach (var purchase in purchases)
            {
                int itemCount = random.Next(1, 4);
                for (int i = 0; i < itemCount; i++)
                {
                    var product = products[random.Next(products.Count)];
                    purchaseItems.Add(new PurchaseItem(random.Next(1, 5), product.Id, purchase.Id)
                    {
                        Id = Guid.NewGuid(),
                        CreatedOn = now.AddHours(-purchaseItemCount * 3)
                    });
                    purchaseItemCount++;
                }
            }

            builder.Entity<ProductCategory>().HasData(categories);
            builder.Entity<Product>().HasData(products);
            builder.Entity<Customer>().HasData(customers);
            builder.Entity<Purchase>().HasData(purchases);
            builder.Entity<PurchaseItem>().HasData(purchaseItems);
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
