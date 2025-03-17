using Application.Stores;
using Domain.Core.Entities;

namespace Application.Services.CustomerN
{
    internal class CustomerService(ICustomerStore _customerStore) : ICustomerService
    {
        public async Task<IEnumerable<Customer>> GetCustomersByDateOfBirth(DateTime dateOfBirth) =>
            await _customerStore.GetCustomersByDateOfBirth(dateOfBirth);

        public async Task<IEnumerable<Customer>> GetCustomersByLastPurchaseDays(int numberOfDays) =>
            await _customerStore.GetCustomersByLastPurchaseDays(numberOfDays);
    }
}
