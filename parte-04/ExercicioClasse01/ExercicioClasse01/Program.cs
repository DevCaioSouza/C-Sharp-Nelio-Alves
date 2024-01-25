using ExercicioClasse01;

Person A, B;

A = new Person();
B = new Person();

Console.WriteLine("Dados da primeira pessoa:");

Console.Write("Nome: ");
A.Name = Console.ReadLine();
Console.Write("Idade: ");
A.Age = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa:");

Console.Write("Nome: ");
B.Name = Console.ReadLine();
Console.Write("Idade: ");
B.Age = int.Parse(Console.ReadLine());

if (A.Age > B.Age)
{
	Console.WriteLine($"A pessoa mais velha é {A.Name}");
} else
{
	Console.WriteLine($"A pessoa mais velha é {B.Name}");
}