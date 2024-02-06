using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Construtores_Sobrecarga_This_Encapsulamento
{
	internal class Product
	{
		private string _name;
		private double _price;
		private int _quantity;

		public Product() { }

		public Product(string name, double price, int quantity)
		{
			_name = name;
			_price = price;
			_quantity = quantity;
		}

		public string GetName()
		{
			return _name;
		}

		public double GetPrice()
		{
			return _price;
		}

		public void SetName(string name)
		{
			if (name != null && name.Length > 1)
			{
				_name = name;
			} 
		}

		public double TotalStockValue()
		{
			return _price * _quantity;
		}

		public void AddProducts(int quantity)
		{
			_quantity += quantity;
		}

		public void RemoveProducts(int quantity)
		{
			_quantity -= quantity;
		}

		public override string ToString()
		{
			return _name
				+ ", $"
				+ _price.ToString("F2", CultureInfo.InvariantCulture)
				+ ", "
				+ _quantity
				+ " unidades, Total: $ "
				+ TotalStockValue().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
