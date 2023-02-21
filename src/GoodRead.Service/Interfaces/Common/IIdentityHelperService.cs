using GoodRead.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.Interfaces.Common
{
    public interface IIdentityHelperService
    {
        UserRole? GetUserRole();
        long? GetUserId();
        string GetUserName();
        string GetUserEmail();
    }
}
