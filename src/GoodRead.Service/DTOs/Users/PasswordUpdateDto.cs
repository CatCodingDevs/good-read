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
    public class PasswordUpdateDto
    {
        [Required, MinLength(6), MaxLength(50)]
        [JsonPropertyName("old_password")]
        [FromForm(Name = "old_password")]
        public string OldPassword { get; set; } = string.Empty;

        [Required, MaxLength(50), MinLength(6)]
        [JsonPropertyName("new_password")]
        [FromForm(Name = "new_password")]
        public string NewPassword { get; set; } = string.Empty;

        [Required, MaxLength(50), MinLength(6)]
        [JsonPropertyName("confirm_password")]
        [FromForm(Name = "confirm_password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
