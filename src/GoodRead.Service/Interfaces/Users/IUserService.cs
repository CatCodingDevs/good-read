using GoodRead.Service.DTOs.Accounts;
using GoodRead.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.Interfaces.Users
{
    public interface IUserService
    {
        Task<bool> UpdateAsync(long id, UserUpdateDto viewModel);
        Task<bool> DeleteAsync(long id);
        Task<UserViewModel> GetIdAsync(long id);
        Task<UserViewModel> GetUsernameAsync(string username);
        Task<bool> ImageUpdateAsync(long id, ImageUploadDto dto);
        Task<IEnumerable<UserViewModel>> GetAllAsync(PaginationParams @params);
        Task<bool> RoleControlAsync(long userId, ushort roleNum);
    }
}
