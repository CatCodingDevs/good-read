using GoodRead.DataAccess.Exceptions;
using GoodRead.DataAccess.Interfaces;
using GoodRead.Service.DTOs.Accounts;
using GoodRead.Service.DTOs.Users;
using GoodRead.Service.Exceptions;
using GoodRead.Service.Interfaces.Common;
using GoodRead.Service.Interfaces.Managments;
using GoodRead.Service.Interfaces.Users;
using GoodRead.Service.Security;
using GoodRead.Service.Services.Common;
using System.Net;

namespace GoodRead.Service.Services.Users
{
    public class AccountService : IAccountService
    {
        private readonly IAuthManager authManager;
        private readonly IIdentityHelperService identity;
        private readonly IUnitOfWork unitOfWork;

        public AccountService(IAuthManager authManager, IUnitOfWork unitOfWork)
        {
            this.authManager = authManager;
            
            this.unitOfWork = unitOfWork;
        }

        public async Task<string> LogInAsync(AccountLoginDto accountLogin)
        {

            var emailedUser = await unitOfWork.UserRepository.GetByEmailAsync(accountLogin.Email);
            if (emailedUser is null) throw new ModelErrorException(nameof(accountLogin.Email), "Email is wrong!");

            var hasherResult = PasswordHasher.Verify(accountLogin.Password, emailedUser.Salt, emailedUser.PasswordHash);
            if (hasherResult)
            {
                string token = authManager.GenerateToken(emailedUser);
                return token;
            }
            else throw new ModelErrorException(nameof(accountLogin.Password), "Email or password is wrong!");

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
