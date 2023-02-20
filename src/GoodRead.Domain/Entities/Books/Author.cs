using GoodRead.Domain.Common;

namespace GoodRead.Domain.Entities.Books
{
    public class Author : Auditable
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
    }
}
