

using Enums_01.Entities;
using Enums_01.Entities.Enums;

Order order = new Order
{
	Id = 1080,
	Moment = DateTime.Now,
	Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

string txt = OrderStatus.PendingPayment.ToString(); // De enum pra string

OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // De string pra enum

Console.WriteLine(txt);
Console.WriteLine();
Console.WriteLine(os);