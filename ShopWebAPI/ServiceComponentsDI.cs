using Application;
using Infrastructure;

namespace ShopWebAPI
{
    public static class ServiceComponentsDI
    {
        public static void AddComponents(this IServiceCollection services)
        {
            services.AddApplicationComponents();
            services.AddInfrastructureComponents();
        }
    }
}
