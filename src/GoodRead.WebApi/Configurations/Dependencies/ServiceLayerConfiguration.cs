using GoodRead.Service.Interfaces.Common;
using GoodRead.Service.Interfaces.Managments;
using GoodRead.Service.Interfaces.Users;
using GoodRead.Service.Services.Common;
using GoodRead.Service.Services.Managments;
using GoodRead.Service.Services.Users;

namespace GoodRead.WebApi.Configurations.Dependencies
{
    public static class ServiceLayerConfiguration
    {
        public static void AddServiceLayer(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IFileService, FileService>();
            builder.Services.AddScoped<IIdentityHelperService, IdentityHelperService>();
            builder.Services.AddScoped<IAuthManager, AuthManager>();
            builder.Services.AddScoped<IEmailService, EmailService>();
            builder.Services.AddScoped<IPaginatorService, PaginatorService>();
            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<IUserService, UserService>();
        }
    }
}
