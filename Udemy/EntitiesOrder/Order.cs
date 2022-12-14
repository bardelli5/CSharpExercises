﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Udemy.EntitiesOrder.Enums;

namespace Udemy.EntitiesOrder
    {
    internal class Order
        {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public Order()
            {
            }

        public Order(DateTime moment, OrderStatus status, Client client)
            {
                Moment = moment;
                Status = status;
                Client = client;
            }

        public void AddItem(OrderItem item) 
            {
                Items.Add(item);
            }
        public void RemoveItem(OrderItem item) 
            {
                Items.Remove(item);
            }
        public double Total()
            {
                double sum = 0.0;
                foreach (OrderItem totalPrice in Items)
                {
                    sum += totalPrice.SubTotal();
                }
                return sum;
            }
        public override string ToString()
            {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem updatedItems in Items)
                {
                    sb.AppendLine(updatedItems.ToString());
                }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
            }
        }
    }
