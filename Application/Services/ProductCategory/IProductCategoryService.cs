using Domain.Core.Entities;

namespace Application.Services.ProductCategoryN
{
    internal interface IProductCategoryService
    {
        Task<IEnumerable<ProductCategory>> GetProductCategoriesByCustomerId(Guid customerId);
    }
}
