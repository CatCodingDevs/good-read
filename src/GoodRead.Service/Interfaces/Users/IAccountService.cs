using GoodRead.Service.DTOs.Accounts;
using GoodRead.Service.DTOs.Users;

namespace GoodRead.Service.Interfaces.Users
{
    public interface IAccountService
    {
        Task<string> LogInAsync(AccountLoginDto accountLogin);

        Task<string> RegisterAsync(AccountRegisterDto accountCreate);

        Task<bool> VerifyEmailAsync(AccountRegisterDto accountCreate, VerifyEmailDto code);

        Task SendCodeAsync(SendToEmailDto sendToEmail);

        Task<bool> VerifyPasswordAsync(UserResetPasswordDto userResetPassword);
    }
}
