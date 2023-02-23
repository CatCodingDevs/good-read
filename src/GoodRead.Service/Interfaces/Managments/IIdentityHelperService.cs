using GoodRead.Domain.Enums;

namespace GoodRead.Service.Interfaces.Managments
{
    public interface IIdentityHelperService
    {
        UserRole? GetUserRole();
        long? GetUserId();
        string GetUserName();
        string GetUserEmail();
    }
}
