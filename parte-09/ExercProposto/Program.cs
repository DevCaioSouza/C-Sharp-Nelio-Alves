

using ExercProposto.Entities;
using ExercProposto.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter client data: ");
Console.Write("Name :");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (MM/dd/yyyy) : ");
DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(name, email, birthDate);
Order order = new Order(DateTime.Now, status, client);

Console.Write("How many items to this order? ");
int TotalItems = int.Parse(Console.ReadLine());

for (int i = 1; i <= TotalItems; i++)
{
	Console.WriteLine($"Enter #{i} data: ");

	Console.Write("Product name: ");
	string productName = Console.ReadLine();
	Console.Write("Product price: ");
	double productPrice = Double.Parse(Console.ReadLine());

	Product product = new Product(productName, productPrice);

	Console.Write("Quantity: ");
	int productQuantity = int.Parse(Console.ReadLine());

	OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

	order.AddItem(orderItem);
}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);


