using GoodRead.Service.DTOs.Accounts;
using GoodRead.Service.DTOs.Common;
using GoodRead.Service.DTOs.Users;
using GoodRead.Service.Interfaces.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.Services.Users
{
    public class UserService : IUserService
    {
        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserUpdateDto>> GetAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<UserUpdateDto> GetIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<UserUpdateDto> GetUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ImageUpdateAsync(long id, ImageUploadDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RoleControlAsync(long userId, ushort roleNum)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(long id, UserUpdateDto viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
