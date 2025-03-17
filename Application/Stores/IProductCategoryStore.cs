using Domain.Core.Entities;

namespace Application.Stores
{
    public interface IProductCategoryStore
    {
        Task<IEnumerable<ProductCategory>> GetProductCategoriesByCustomerId(Guid customerId);
    }
}
