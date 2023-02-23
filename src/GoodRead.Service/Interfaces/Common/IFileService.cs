using Microsoft.AspNetCore.Http;

namespace GoodRead.Service.Interfaces.Common
{
    public interface IFileService
    {
        public string ImageFolderName { get; }
        Task<string> SaveImageAsync(IFormFile image);
        Task<bool> DeleteImageAsync(string relativeFilePath);
    }
}
