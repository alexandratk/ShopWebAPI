using Application.Stores;
using Infrastructure.Stores;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceComponentsDI
    {
        public static void AddInfrastructureComponents(this IServiceCollection services)
        {
            services.AddTransient<ICustomerStore, CustomerStore>();
            services.AddTransient<IProductCategoryStore, ProductCategoryStore>();
        }
    }
}
