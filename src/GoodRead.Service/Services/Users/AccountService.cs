using GoodRead.Service.DTOs.Accounts;
using GoodRead.Service.DTOs.Users;
using GoodRead.Service.Interfaces.Common;
using GoodRead.Service.Interfaces.Managments;
using GoodRead.Service.Interfaces.Users;
using GoodRead.Service.Services.Common;

namespace GoodRead.Service.Services.Users
{
    public class AccountService : IAccountService
    {
        private readonly IAuthManager authManager;
        private readonly IIdentityHelperService identity;

        public AccountService(IAuthManager authManager, IIdentityHelperService identity)
        {
            this.authManager = authManager;
            this.identity = identity;
        }

        public Task<string> LogInAsync(AccountLoginDto accountLogin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterAsync(AccountRegisterDto accountCreate)
        {
            throw new NotImplementedException();
        }

        public Task SendCodeAsync(SendToEmailDto sendToEmail)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyEmailAsync(VerifyEmailDto verifyEmail)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyPasswordAsync(UserResetPasswordDto userResetPassword)
        {
            throw new NotImplementedException();
        }
    }
}
