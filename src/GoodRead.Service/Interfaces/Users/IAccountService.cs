using GoodRead.Service.DTOs.Accounts;
using GoodRead.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
