using GoodRead.Domain.Entities.Users;

namespace GoodRead.DataAccess.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<User> GetByEmailAsync(string email);
    }
}
