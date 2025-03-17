using Application.Stores;
using Domain.Core.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Stores
{
    internal class ProductCategoryStore(ShopDbContext _dbContext) : IProductCategoryStore
    {
        public async Task<IEnumerable<ProductCategory>> GetProductCategoriesByCustomerId(Guid customerId)
            => await _dbContext.ProductCategories
                .Where(pc => pc.Products.Any(p => p.PurchaseItems.Any(pi => pi.Purchase.CustomerId == customerId)))
                .Include(pc => pc.Products)
                .ThenInclude(p => p.PurchaseItems)
                .ToListAsync();
    }
}
