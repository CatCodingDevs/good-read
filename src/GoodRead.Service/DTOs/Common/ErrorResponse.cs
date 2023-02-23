using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace GoodRead.Service.DTOs.Common
{
    public class ErrorResponse
    {
        [JsonPropertyName("status_code")]
        [FromForm(Name = "status_code")]
        public int StatusCode { get; set; }

        [JsonPropertyName("message")]
        [FromForm(Name = "message")]
        public string Message { get; set; } = null!;
    }
}
