using GoodRead.DataAccess.DbContexts;
using GoodRead.DataAccess.Interfaces;
using GoodRead.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace GoodRead.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<User> GetByEmailAsync(string email)
        {
            var user = await _dbSet.FirstOrDefaultAsync(x => x.Email.Equals(email));
            return user;
        }
    }
}
