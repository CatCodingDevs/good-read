using GoodRead.Domain.Common;
using GoodRead.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Domain.Entities.Orders
{
    public class Order : Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public decimal TotalSum { get; set; }
    }
}
