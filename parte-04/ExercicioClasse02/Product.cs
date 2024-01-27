using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasse02
{
	internal class Product
	{
		public string Name;
		public double Price;
		public int Quantity;

		public double TotalStockValue()
		{
			return Price * Quantity;
		}

		public void AddProducts(int quantity)
		{
			Quantity += quantity; // equivale a Quantity = Quantity + quantity
		}

		public void RemoveProducts(int quantity) 
		{ 
			Quantity -= quantity;
		}

	}
}
