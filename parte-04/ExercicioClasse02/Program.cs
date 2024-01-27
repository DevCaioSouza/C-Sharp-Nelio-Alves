// See https://aka.ms/new-console-template for more information
using System.Globalization;

using ExercicioClasse02;

Product newProduct = new Product();

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
newProduct.Name = Console.ReadLine();

Console.Write("Preço: ");
newProduct.Price = double.Parse(Console.ReadLine());

Console.Write("Quantidade no estoque: ");
newProduct.Quantity = int.Parse(Console.ReadLine());

Console.WriteLine($"Dados do produto: {newProduct.Name}, preço: $ {newProduct.Price:F2}, quantidade: {newProduct.Quantity}, Total: $ {newProduct.TotalStockValue():F2} ");

Console.Write($"Digite o número de {newProduct.Name.ToLower()}s a serem adicionados no estoque: ");
int qttAdd = int.Parse(Console.ReadLine());
newProduct.AddProducts(qttAdd);

Console.WriteLine($"Dados Atualizados: {newProduct.Name}, preço: $ {newProduct.Price:F2}, quantidade: {newProduct.Quantity}, Total: $ {newProduct.TotalStockValue():F2} ");

// Bloco da remoção de produto

void RemoveBlock()
{
	Console.Write("Digite o número de produtos a serem removidos do estoque: ");
	int qteRem = int.Parse(Console.ReadLine());

	if (qteRem > newProduct.Quantity)
	{
		Console.WriteLine("*** ERRO: A quantidade removida não pode ser maior do que a quantidade existente ***");
		RemoveBlock();
	}
	else
	{
		Console.WriteLine($"Dados Atualizados: {newProduct.Name}, $ {newProduct.Price:F2}, {newProduct.Quantity}, Total: $ {newProduct.TotalStockValue():F2} ");
		Console.WriteLine("*** PROGRAMA FINALIZADO. APERTE QUALQUER TECLA PARA SAIR ***");
	}
}

RemoveBlock();


