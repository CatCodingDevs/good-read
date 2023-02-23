using GoodRead.Domain.Entities.Users;
using GoodRead.Service.Attributes;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GoodRead.Service.DTOs.Users
{
    public class UserUpdateDto
    {
        [Required, Name]
        [JsonPropertyName("firstname")]
        [FromForm(Name = "firstname")]
        public string Firstname { get; set; } = string.Empty;

        [Required, Name]
        [JsonPropertyName("lastname")]
        [FromForm(Name = "lastname")]
        public string Lastname { get; set; } = string.Empty;

        [Required, Email]
        [JsonPropertyName("email")]
        [FromForm(Name = "email")]
        public string Email { get; set; } = string.Empty;

        public static implicit operator User(UserUpdateDto userUpdate)
        {
            return new User()
            {
                FirstName = userUpdate.Firstname,
                LastName = userUpdate.Lastname,
            };
        }
    }
}
