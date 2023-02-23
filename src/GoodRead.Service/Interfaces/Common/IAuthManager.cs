using GoodRead.Domain.Entities.Users;

namespace GoodRead.Service.Interfaces.Common
{
    public interface IAuthManager
    {
        public string GenerateToken(User user);
    }
}
