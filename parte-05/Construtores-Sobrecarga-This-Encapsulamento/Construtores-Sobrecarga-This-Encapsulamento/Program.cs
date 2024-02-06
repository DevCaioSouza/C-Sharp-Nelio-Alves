

using Construtores_Sobrecarga_This_Encapsulamento;

Product p = new Product("TV", 500, 10);

p.Name = "TV 4K"; // Aqui estamos usando o Set, pra alterar o valor!!

Console.WriteLine("Nome: " + p.Name + " " + " Preço: " + p.Price + " Quantidade: " + p.Quantity );