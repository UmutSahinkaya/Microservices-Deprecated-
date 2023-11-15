﻿using Services.Order.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Order.Domain.OrderAggregate
{
    //EF Core features
    //--Owned Types
    //--Shadow Property
    //--Backing Field
    public class Order:Entity,IAggregateRoot
    {
        public DateTime CreatedDate { get;private set; } // Property
        public Address Address { get;private set; }
        public string BuyerId { get;private set; }

        private readonly List<OrderItem> _orderItems; //Field
        public Order()
        {
            
        }
        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;

        public Order(string buyerId, Address address)
        {
            _orderItems= new List<OrderItem>();
            CreatedDate = DateTime.Now;
            Address = address;
            BuyerId = buyerId;
        }

        public void AddOrderItem(string productId,string productName,decimal price,string pictureUrl)
        {
            var existProduct = _orderItems.Any(x=>x.ProductId==productId);
            if(!existProduct)
            {
                var newOrderItem = new OrderItem(productId, productName, pictureUrl, price);
                _orderItems.Add(newOrderItem);
            }
        }
        public decimal GetTotalPrice => _orderItems.Sum(x=>x.Price);
    }
}
