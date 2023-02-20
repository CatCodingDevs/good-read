using GoodRead.Domain.Common;
using GoodRead.Domain.Entities.Books;

namespace GoodRead.Domain.Entities.Orders
{
    public class OrderDetail : Auditable
    {
        public long OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public long BookId { get; set; }
        public Book Book { get; set; } = null!;

        public int BookCount { get; set; }
    }
}
