using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Xml.Linq;

namespace Construtores_Sobrecarga_This_Encapsulamento
{
	internal class Product
	{
		private string _name;
        public double Price { get; private set; }

        public int Quantity { get; private set; }

        public Product() { }

		public Product(string name, double price, int quantity)
		{
			_name = name;
			Price = price;
			Quantity = quantity;
		}

        public string Name
		{
			get { return _name; }
			set {
				if (value != null && value.Length > 1) 
				{
					_name = value;
				}
			}
		}
		public double TotalStockValue()
		{
			return Price * Quantity;
		}

		public void AddProducts(int quantity)
		{
			Quantity += quantity;
		}

		public void RemoveProducts(int quantity)
		{
			Quantity -= quantity;
		}

		public override string ToString()
		{
			return _name
				+ ", $"
				+ Price.ToString("F2", CultureInfo.InvariantCulture)
				+ ", "
				+ Quantity
				+ " unidades, Total: $ "
				+ TotalStockValue().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
