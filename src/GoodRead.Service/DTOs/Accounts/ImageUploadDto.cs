using GoodRead.Service.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GoodRead.Service.DTOs.Accounts
{
    public class ImageUploadDto
    {
        [Required(ErrorMessage = "Image is required")]
        [DataType(DataType.Upload)]
        [MaxFileSize(1)]
        [JsonPropertyName("image")]
        [FromForm(Name = "image")]
        [AllowedFiles(new string[] { ".jpg", ".png", ".jpeg", ".svg", ".webp" })]
        public IFormFile Image { get; set; } = null!;
    }
}
