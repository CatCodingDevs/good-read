using GoodRead.Service.DTOs.Common;

namespace GoodRead.Service.Interfaces.Common
{
    public interface IEmailService
    {
        public Task SendAsync(EmailMessage message);
    }
}
