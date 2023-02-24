using GoodRead.DataAccess.DbContexts;
using GoodRead.DataAccess.Interfaces;
using GoodRead.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GoodRead.WebApi.Configurations.Dependencies
{
    public static class DataAccessLayerConfiguration
    {
        public static void AddDataAccessLayer(this WebApplicationBuilder builder)
        {
            string connectionString = builder.Configuration.GetConnectionString("GoodReadDb");
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
        }
    }
}
