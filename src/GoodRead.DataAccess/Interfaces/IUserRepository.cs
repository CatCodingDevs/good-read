using GoodRead.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.DataAccess.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
    }
}
