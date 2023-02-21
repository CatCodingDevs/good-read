using GoodRead.Service.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.Interfaces.Common
{
    public interface IEmailService
    {
        public Task SendAsync(EmailMessage message);
    }
}
