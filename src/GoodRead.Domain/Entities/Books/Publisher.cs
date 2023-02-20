using GoodRead.Domain.Common;


namespace GoodRead.Domain.Entities.Books
{
    public class Publisher : Auditable
    {
        public string Name { get; set; } = String.Empty;
    }
}
