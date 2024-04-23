using ExercProposto.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercProposto.Entities
{
	internal class Order
	{
		public DateTime Moment { get; set; }
		public OrderStatus Status { get; set; }
		public Client Client { get; set; }
		public List<OrderItem> OrderItems = new List<OrderItem>();

		public Order() { }

		public Order(DateTime moment, OrderStatus status, Client client)
		{
			Moment = moment;
			Status = status;
			Client = client;
		}

		public void AddItem(OrderItem item)
		{
			OrderItems.Add(item);
		}

		public void RemoveItem(OrderItem item)
		{
			OrderItems.Add(item);
		}

		public double Total()
		{
			double sum = 0.0;
			foreach (OrderItem item in OrderItems)
			{
				sum += item.SubTotal();
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
			foreach (OrderItem item in OrderItems)
			{
				sb.AppendLine(item.ToString());
			}
			sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
			return sb.ToString();
		}
	}
}
