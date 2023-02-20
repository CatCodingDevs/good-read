using GoodRead.Domain.Common;
using GoodRead.Domain.Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Domain.Entities.Orders
{
    public class OrderDetail : Auditable
    {
        public long OrderId { get; set; }
        public Order Order { get; set; }
        
        public long BookId { get; set; }
        public Book Book { get; set; }

        public int BookCount { get; set; }
    }
}
