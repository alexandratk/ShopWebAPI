using Application.Common;
using Application.DTOs;
using Application.Services.CustomerN;
using Domain.Core.Entities;

namespace Application.Queries.GetCustomersByLastPurchaseDays
{
    internal class GetCustomersByLastPurchaseDaysQueryHandler(ICustomerService _customerService)
        : IQueryHandler<GetCustomersByLastPurchaseDaysQuery, IEnumerable<PurchaseCustomerInfoDTO>>
    {
        public async Task<IEnumerable<PurchaseCustomerInfoDTO>> Handle(GetCustomersByLastPurchaseDaysQuery request, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(request);
            if (request.NumberOfDays < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(request.NumberOfDays), "Number of days must be greater than or equal to 0");
            }

            IEnumerable<Customer> customers = await _customerService.GetCustomersByLastPurchaseDays(request.NumberOfDays);
            IEnumerable<PurchaseCustomerInfoDTO> purchaseCustomerInfos = customers.Select(c => new PurchaseCustomerInfoDTO
            {
                Id = c.Id,
                FullName = c.FullName,
                LastPurchaseDate = c.Purchases.Max(p => p.CreatedOn)
            });

            return purchaseCustomerInfos;
        }
    }
}
