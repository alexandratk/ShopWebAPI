using Domain.Core.Entities;

namespace Application.Services.CustomerN
{
    internal interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomersByDateOfBirth(DateTime dateOfBirth);
        Task<IEnumerable<Customer>> GetCustomersByLastPurchaseDays(int numberOfDays);
    }
}
