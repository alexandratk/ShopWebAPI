using Application.Services.CustomerN;
using Application.Services.ProductCategoryN;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ServiceComponentsDI
    {
        public static void AddApplicationComponents(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IProductCategoryService, ProductCategoryService>();
        }
    }
}
