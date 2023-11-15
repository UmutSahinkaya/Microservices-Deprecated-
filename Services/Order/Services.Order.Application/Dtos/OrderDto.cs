using Services.Order.Domain.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Order.Application.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } // Property
        public AddressDto Address { get; set; }
        public string BuyerId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
    }
}
