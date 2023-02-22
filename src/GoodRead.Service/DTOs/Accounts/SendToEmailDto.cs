using GoodRead.Service.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GoodRead.Service.DTOs.Accounts
{
    public class SendToEmailDto
    {
        [Required(ErrorMessage = "Email is required"), Email]
        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;
    }
}
