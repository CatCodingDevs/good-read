using GoodRead.Service.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GoodRead.Service.DTOs.Accounts
{
    public class SendToEmailDto
    {
        [Required(ErrorMessage = "Email is required"), Email]
        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;
    }
}
