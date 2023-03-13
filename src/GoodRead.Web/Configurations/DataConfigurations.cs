using GoodRead.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace GoodRead.Web.Configurations
{
    public static class DataConfigurations
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("GoodReadDb")!;
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(connectionString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
            return services;
        }
    }
}
