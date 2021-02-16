using EnumeraçõesComposições.CourseExercise02.Entities.Enums;
using EnumeraçõesComposições.CourseExercise02.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EnumeraçõesComposições.CourseExercise02.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        
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

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("\nOrder items:");

            foreach (OrderItem Z in Items)
            {
                sb.AppendLine(Z.ToString());
            }
            sb.AppendLine("\nTotal price: $ " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
