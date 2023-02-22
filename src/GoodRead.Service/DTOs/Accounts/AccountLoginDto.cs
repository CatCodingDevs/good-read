using GoodRead.Domain.Entities.Users;
using GoodRead.Service.Attributes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GoodRead.Service.DTOs.Accounts
{
    public class AccountLoginDto
    {
        [Required, Email]
        [JsonPropertyName("email")]
        [FromForm(Name = "email")]
        public string Email { get; set; } = string.Empty;

        [Required, MinLength(6), MaxLength(50)]
        [JsonPropertyName("password")]
        [FromForm(Name = "password")]
        public string Password { get; set; } = string.Empty;

        public static implicit operator User(AccountLoginDto accountLoginDto)
        => new User()
           {
               Email = accountLoginDto.Email,
           };
    }
}
