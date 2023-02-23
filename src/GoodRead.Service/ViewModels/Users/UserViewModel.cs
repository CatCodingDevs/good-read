using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace GoodRead.Service.ViewModels.Users
{
    public class UserViewModel
    {
        [JsonPropertyName("id")]
        [FromForm(Name = "id")]
        public long Id { get; set; }

        [JsonPropertyName("firstname")]
        [FromForm(Name = "firstname")]
        public string FirstName { get; set; } = String.Empty;

        [JsonPropertyName("lastname")]
        [FromForm(Name = "lastname")]
        public string LastName { get; set; } = String.Empty;

        [JsonPropertyName("email")]
        [FromForm(Name = "email")]
        public string Email { get; set; } = String.Empty;
    }
}