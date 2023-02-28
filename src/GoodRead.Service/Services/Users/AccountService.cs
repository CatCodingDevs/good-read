using GoodRead.DataAccess.Exceptions;
using GoodRead.DataAccess.Interfaces;
using GoodRead.Domain.Entities.Users;
using GoodRead.Service.DTOs.Accounts;
using GoodRead.Service.DTOs.Common;
using GoodRead.Service.DTOs.Users;
using GoodRead.Service.Exceptions;
using GoodRead.Service.Interfaces.Common;
using GoodRead.Service.Interfaces.Managments;
using GoodRead.Service.Interfaces.Users;
using GoodRead.Service.Security;
using GoodRead.Service.Services.Common;
using Microsoft.Extensions.Caching.Memory;
using System.Net;

namespace GoodRead.Service.Services.Users
{
    public class AccountService : IAccountService
    {
        private readonly IAuthManager authManager;
        private readonly IIdentityHelperService identity;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMemoryCache _cache;
        private readonly IEmailService _emailService;

        public AccountService(IAuthManager authManager, IUnitOfWork unitOfWork, IMemoryCache cache, IEmailService emailService)
        {
            this.authManager = authManager;
            
            this.unitOfWork = unitOfWork;
            this._cache = cache;
            this._emailService = emailService;
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

        public async Task<bool> RegisterAsync(AccountRegisterDto accountCreate)
        {
            var user = await unitOfWork.UserRepository.GetByEmailAsync(accountCreate.Email.ToLower());
            if (user is not null) throw new StatusCodeException(HttpStatusCode.BadRequest, message: "user already exist");

            var newUser = (User)accountCreate;
            var hashResult = PasswordHasher.Hash(accountCreate.Password);
            newUser.Salt = hashResult.Salt;
            newUser.PasswordHash = hashResult.Hash;

            await unitOfWork.UserRepository.CreateAsync(newUser);

            var email = new SendToEmailDto();
            email.Email = accountCreate.Email;

            await SendCodeAsync(email);

            return true;
        }

        public async Task SendCodeAsync(SendToEmailDto sendToEmail)
        {
            int code = new Random().Next(10000, 99999);

            _cache.Set(sendToEmail.Email, code, TimeSpan.FromMinutes(10));

            var message = new EmailMessage()
            {
                To = sendToEmail.Email,
                Subject = "Verifcation code",
                Body = code.ToString()
            };

            await _emailService.SendAsync(message);
        }

        public async Task<bool> VerifyEmailAsync(VerifyEmailDto verifyEmail)
        {
            var user = await unitOfWork.UserRepository.GetByEmailAsync(verifyEmail.Email);

            if (user is null)
                throw new StatusCodeException(HttpStatusCode.NotFound, message: "User not found");

            if (_cache.TryGetValue(verifyEmail.Email, out int expectedCode) is false)
                throw new StatusCodeException(HttpStatusCode.BadRequest, message: "Code is expired");

            if (expectedCode != verifyEmail.Code)
                throw new StatusCodeException(HttpStatusCode.BadRequest, message: "Code is wrong");

            user.ConfirmEmail = true;
            await unitOfWork.UserRepository.UpdateAsync(user.Id, user);
            return true;
        }

        public async Task<bool> VerifyPasswordAsync(UserResetPasswordDto userResetPassword)
        {
            var user = await unitOfWork.UserRepository.GetByEmailAsync(userResetPassword.Email);

            if (user is null)
                throw new StatusCodeException(HttpStatusCode.NotFound, message: "User not found");

            if (user.ConfirmEmail is false)
                throw new StatusCodeException(HttpStatusCode.BadRequest, message: "Email did not verified");

            var changedPassword = PasswordHasher.Hash(userResetPassword.Password, user.Salt);

            user.PasswordHash = changedPassword;

            await unitOfWork.UserRepository.UpdateAsync(user.Id, user);

            return true;
        }
    }
}
