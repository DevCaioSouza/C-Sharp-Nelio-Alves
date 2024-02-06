

using Construtores_Sobrecarga_This_Encapsulamento;

Product p = new Product("TV", 500, 10);

string Name = p.GetName();

Console.WriteLine("Forma 1: " + Name);

//Outra maneira

Console.WriteLine("Forma 2: " + p.GetName());

p.SetName("Celular");

Console.WriteLine("Novo nome: " + p.GetName() + ", Novo preço: " + p.GetPrice());