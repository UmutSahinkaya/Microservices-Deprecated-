using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Order.Application.Dtos
{
    public class OrderItemDto
    {
        public string ProductId { get; private set; }
        public string ProductName { get; private set; }
        public string PictureUrl { get; private set; }
        public Decimal Price { get; private set; }
    }
}
