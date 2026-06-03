using _08_ProductOrderApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08_ProductOrderApp.Entities
{
    internal class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order() { }
        public Order(DateTime date, OrderStatus status)
        {
            Date = date;
            Status = status;
        }
        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach(OrderItem orderItem in OrderItems)
            {
                total += orderItem.subTotal();
            }
            return total;
        }
    }
}
