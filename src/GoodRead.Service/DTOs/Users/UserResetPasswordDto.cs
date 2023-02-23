using GoodRead.Service.Attributes;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GoodRead.Service.DTOs.Users
{
    public class UserResetPasswordDto
    {
        [Required(ErrorMessage = "Email is required"), Email]
        [JsonPropertyName("email")]
        [FromForm(Name = "email")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("code")]
        [FromForm(Name = "code")]
        public int Code { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [JsonPropertyName("password")]
        [FromForm(Name = "password")]
        public string Password { get; set; } = string.Empty;
    }
}
