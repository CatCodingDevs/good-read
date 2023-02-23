using GoodRead.Domain.Common;
using GoodRead.Domain.Entities.Users;

namespace GoodRead.Domain.Entities.Orders
{
    public class Order : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; } = null!;
        public decimal TotalSum { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}
