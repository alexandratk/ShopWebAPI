using Application.Stores;
using Domain.Core.Entities;

namespace Application.Services.ProductCategoryN
{
    internal class ProductCategoryService(IProductCategoryStore _productCategoryStore) : IProductCategoryService
    {
        public async Task<IEnumerable<ProductCategory>> GetProductCategoriesByCustomerId(Guid customerId) =>
            await _productCategoryStore.GetProductCategoriesByCustomerId(customerId);
    }
}
