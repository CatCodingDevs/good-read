using GoodRead.Domain.Entities.Users;
using GoodRead.Service.Attributes;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GoodRead.Service.DTOs.Accounts
{
    public class AccountRegisterDto
    {
        [Required, Email]
        [JsonPropertyName("email")]
        [FromForm(Name = "email")]
        public string Email { get; set; } = String.Empty;

        [Required, MaxLength(50), MinLength(6)]
        [JsonPropertyName("password")]
        [FromForm(Name = "password")]
        public string Password { get; set; } = String.Empty;

        public string FirstName { get; set;} = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public static implicit operator User(AccountRegisterDto dto)
        {
            return new User()
            {
                Email = dto.Email,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
            };
        }
    }
}
