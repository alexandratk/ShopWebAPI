using Application.Common;
using Application.DTOs;
using Application.Services.ProductCategoryN;
using AutoMapper;
using Domain.Core.Entities;

namespace Application.Queries.GetProductCategoriesByCustomerId
{
    internal class GetProductCategoriesByCustomerIdQueryHandler(IProductCategoryService _productCategoryService, IMapper _mapper)
        : IQueryHandler<GetProductCategoriesByCustomerIdQuery, IEnumerable<ProductCategoryDTO>>
    {
        public async Task<IEnumerable<ProductCategoryDTO>> Handle(GetProductCategoriesByCustomerIdQuery request, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(request);

            IEnumerable<ProductCategory> productCategories = await _productCategoryService.GetProductCategoriesByCustomerId(request.CustomerId);

            return productCategories.Select(x =>
                new ProductCategoryDTO()
                {
                    Id = x.Id,
                    Name = x.Name,
                    TotalQuantity = x.Products.Sum(p => p.PurchaseItems.Sum(i => i.Quantity))
                });
        }
    }
}
