using GoodRead.Service.Attributes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.DTOs.Accounts
{
    public class ImageUploadDto
    {
        [Required(ErrorMessage = "Image is required")]
        [DataType(DataType.Upload)]
        [MaxFileSize(1)]
        [AllowedFiles(new string[] { ".jpg", ".png", ".jpeg", ".svg", ".webp" })]
        public IFormFile Image { get; set; } = null!;
    }
}
