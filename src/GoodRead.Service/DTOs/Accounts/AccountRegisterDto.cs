using GoodRead.Domain.Entities.Users;
using GoodRead.Service.Attributes;
using Microsoft.AspNetCore.Mvc;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GoodRead.Service.DTOs.Accounts
{
    public class AccountRegisterDto
    {
        [Required, Email]
        [JsonPropertyName("email")]
        [FromForm(Name = "email")]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(50), MinLength(6)]
        [JsonPropertyName("password")]
        [FromForm(Name = "password")]
        public string Password { get; set; } = string.Empty;

        public static implicit operator User(AccountRegisterDto dto)
        {
            return new User()
            {
                Email = dto.Email,
            };
        }
    }
}
