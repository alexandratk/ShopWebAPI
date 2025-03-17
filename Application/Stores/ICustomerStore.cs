using Domain.Core.Entities;

namespace Application.Stores
{
    public interface ICustomerStore
    {
        Task<IEnumerable<Customer>> GetCustomersByDateOfBirth(DateTime dateOfBirth);
        Task<IEnumerable<Customer>> GetCustomersByLastPurchaseDays(int numberOfDays);
    }
}
