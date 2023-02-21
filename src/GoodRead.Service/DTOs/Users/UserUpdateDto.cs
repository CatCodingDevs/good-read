using GoodRead.Domain.Entities.Users;
using GoodRead.Service.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.DTOs.Users
{
    public class UserUpdateDto
    {
        [Required, Name]
        public string Firstname { get; set; } = string.Empty;

        [Required, Name]
        public string Lastname { get; set; } = string.Empty;

        [Required, Email]
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
