using GoodRead.Domain.Common;
using GoodRead.Domain.Entities.Addresses;
using GoodRead.Domain.Enums;

namespace GoodRead.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public bool ConfirmEmail { get; set; }
        public string PasswordHash { get; set; } = String.Empty;
        public string Salt { get; set; } = String.Empty;

        public UserRole Role { get; set; } = UserRole.User;

        public ICollection<Address> Address { get; set; } = null!;
    }
}
