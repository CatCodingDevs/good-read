using GoodRead.Domain.Common;

namespace GoodRead.Domain.Entities.Books
{
    public class Genre : Auditable
    {
        public string Name { get; set; } = String.Empty;
    }
}
