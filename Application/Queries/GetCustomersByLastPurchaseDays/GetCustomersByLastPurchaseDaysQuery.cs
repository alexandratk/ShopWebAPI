using Application.DTOs;
using MediatR;

namespace Application.Queries.GetCustomersByLastPurchaseDays
{
    public class GetCustomersByLastPurchaseDaysQuery : IRequest<IEnumerable<PurchaseCustomerInfoDTO>>
    {
        public int NumberOfDays { get; set; }
    }
}
