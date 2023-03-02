using GoodRead.DataAccess.Exceptions;
using GoodRead.DataAccess.Interfaces;
using GoodRead.Service.DTOs.Accounts;
using GoodRead.Service.DTOs.Users;
using GoodRead.Service.Interfaces.Common;
using GoodRead.Service.Interfaces.Managments;
using GoodRead.Service.Interfaces.Users;
using GoodRead.Service.Services.Common;
using Microsoft.AspNetCore.Http.HttpResults;

namespace GoodRead.Service.Services.Users
{
    public class AccountService : IAccountService
    {
        private readonly IAuthManager authManager;
        private readonly IIdentityHelperService identity;
        private readonly IUnitOfWork unit;

        public AccountService(IAuthManager authManager, IIdentityHelperService identity, IUnitOfWork unit)
        {
            this.authManager = authManager;
            this.identity = identity;
            this.unit = unit;
        }

        public async Task<string> LogInAsync(AccountLoginDto accountLogin)
        {
            var result = await unit.UserRepository.GetAsync(x => x.Email == accountLogin.Email);
            if (result is null)
            {
                return StatusCodeException()
            }
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
