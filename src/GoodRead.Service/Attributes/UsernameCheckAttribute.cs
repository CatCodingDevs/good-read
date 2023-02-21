using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class UsernameCheckAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var username = (string)value!;
            if (!username.Contains("@"))
                return ValidationResult.Success;

            return new ValidationResult($"Cannot use '@' in username");
        }
    }
}
