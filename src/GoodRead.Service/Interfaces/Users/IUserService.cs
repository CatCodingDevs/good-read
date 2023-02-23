using GoodRead.Service.DTOs.Accounts;
using GoodRead.Service.DTOs.Common;
using GoodRead.Service.DTOs.Users;

namespace GoodRead.Service.Interfaces.Users
{
    public interface IUserService
    {
        Task<bool> UpdateAsync(long id, UserUpdateDto viewModel);
        Task<bool> DeleteAsync(long id);
        Task<UserUpdateDto> GetIdAsync(long id);
        Task<UserUpdateDto> GetUsernameAsync(string username);
        Task<bool> ImageUpdateAsync(long id, ImageUploadDto dto);
        Task<IEnumerable<UserUpdateDto>> GetAllAsync(PaginationParams @params);
        Task<bool> RoleControlAsync(long userId, ushort roleNum);
    }
}
