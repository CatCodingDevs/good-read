using GoodRead.Service.DTOs.Accounts;
using GoodRead.Service.DTOs.Users;

namespace GoodRead.Service.Interfaces.Users
{
    public interface IAccountService
    {
        Task<string> LogInAsync(AccountLoginDto accountLogin);

        Task<bool> RegisterAsync(AccountRegisterDto accountCreate);

        Task<bool> VerifyEmailAsync(VerifyEmailDto verifyEmail);

        Task SendCodeAsync(SendToEmailDto sendToEmail);

        Task<bool> VerifyPasswordAsync(UserResetPasswordDto userResetPassword);
    }
}
