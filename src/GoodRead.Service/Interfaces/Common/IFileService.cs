using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.Interfaces.Common
{
    public interface IFileService
    {
        public string ImageFolderName { get; }
        Task<string> SaveImageAsync(IFormFile image);
        Task<bool> DeleteImageAsync(string relativeFilePath);
    }
}
