using Application.DTOs;
using MediatR;

namespace Application.Queries.GetProductCategoriesByCustomerId
{
    public class GetProductCategoriesByCustomerIdQuery : IRequest<IEnumerable<ProductCategoryDTO>>
    {
        public Guid CustomerId { get; set; }
    }
}
