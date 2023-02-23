using GoodRead.Domain.Entities.Books;
using GoodRead.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.DTOs.Orders
{
    public class OrderDetailCreateDto
    {
        public long OrderId { get; set; }
        public long BookId { get; set; }
        public int BookCount { get; set; }

        public static implicit operator OrderDetail(OrderDetailCreateDto orderDetailCreateDto)
        {
            return new OrderDetail()
            {
                OrderId = orderDetailCreateDto.OrderId,
                BookId = orderDetailCreateDto.BookId,
                BookCount = orderDetailCreateDto.BookCount,
            };
        }
    }
}
