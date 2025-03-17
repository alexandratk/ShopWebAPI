using Application.Stores;
using Domain.Core.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Stores
{
    internal class CustomerStore(ShopDbContext _dbContext) : ICustomerStore
    {
        public async Task<IEnumerable<Customer>> GetCustomersByDateOfBirth(DateTime dateOfBirth) =>
            await _dbContext.Customers.AsNoTracking().Where(c => c.DateOfBirth == dateOfBirth).ToListAsync();

        public async Task<IEnumerable<Customer>> GetCustomersByLastPurchaseDays(int numberOfDays)
        {
            DateTime dateThreshold = DateTime.UtcNow.AddDays(numberOfDays);

            return await _dbContext.Customers
                .Include(x => x.Purchases)
                .AsNoTracking()
                .Where(c => c.Purchases.Any(p => p.CreatedOn >= dateThreshold))
                .ToListAsync();
        }
    }
}
