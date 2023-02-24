using GoodRead.Service.Attributes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
