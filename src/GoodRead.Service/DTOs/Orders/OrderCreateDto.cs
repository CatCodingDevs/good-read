using GoodRead.Domain.Entities.Orders;
using GoodRead.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.DTOs.Orders
{
    public class OrderCreateDto
    {
        public long UserId { get; set; }
        public decimal TotalSum { get; set; }

        ICollection<OrderDetail> OrderDetails { get; set; } = null!;

        public static implicit operator Order(OrderCreateDto orderCreateDto)
        {
            return new Order()
            {
                UserId = orderCreateDto.UserId,
                TotalSum = orderCreateDto.TotalSum,
                OrderDetails = orderCreateDto.OrderDetails,
            };
        }
    }
}
