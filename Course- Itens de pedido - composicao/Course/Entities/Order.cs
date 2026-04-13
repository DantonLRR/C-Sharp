using Course.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

            
        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }
        public double Total()
        {
            double total = 0;
            foreach(OrderItem value in OrderItems)
            {
                total += value.SubTotal();
            }
            return total;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            double total = 0;
            sb.AppendLine("ORDER SUMMARY: ");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Client.Email);

            sb.AppendLine("Order Items: ");
           foreach(OrderItem valuesOrder in OrderItems)
            {
                sb.Append(valuesOrder.Product.Name);
                sb.Append(", $");
                sb.Append(valuesOrder.Price);
                sb.Append(", Quantity: ");
                sb.Append(valuesOrder.Quantity);
                sb.Append(", Subtotal: $");
                sb.AppendLine(valuesOrder.SubTotal().ToString("F2"));
                total += valuesOrder.SubTotal();
            }
            sb.Append("Total Price: ");
            sb.Append(total.ToString("F2"));
            return sb.ToString();
        }
    }
}
