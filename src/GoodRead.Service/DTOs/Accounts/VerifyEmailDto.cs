using GoodRead.Service.Attributes;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GoodRead.Service.DTOs.Accounts
{
    public class VerifyEmailDto
    {
        [Required(ErrorMessage = "Email is required"), Email]
        [JsonPropertyName("email")]
        [FromForm(Name = "email")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [JsonPropertyName("code")]
        [FromForm(Name = "code")]
        public int Code { get; set; }
    }
}
