using GoodRead.DataAccess.Interfaces;
using GoodRead.DataAccess.Repositories;
using GoodRead.Service.Interfaces.Books;
using GoodRead.Service.Interfaces.Common;
using GoodRead.Service.Interfaces.Users;
using GoodRead.Service.Services.Books;
using GoodRead.Service.Services.Common;
using GoodRead.Service.Services.Users;

namespace GoodRead.Web.Configurations
{
    public static class ServiceConfigurations
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAuthManager, AuthManager>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IBookService, BookService>();
            services.AddMemoryCache();
            return services;
        }
    }
}
