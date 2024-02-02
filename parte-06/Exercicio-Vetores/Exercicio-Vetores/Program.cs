using Exercicio_Vetores;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

int[] AllRooms = new int[10];

Console.WriteLine("Quantos estudantes alugarão quartos? ");
Console.Write("Escolha um número de 1 a 10. ");

int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (n > 10 || n == 0)
{
    Console.WriteLine("Erro. O número precisa ser de 1 a 10. Programa encerrando. ");
}

Student[] vector = new Student[n];

for(int i = 0; i < n; i++)
{
    Console.WriteLine($"Digite o NOME do estudante {i + 1} : ");
	string name = Console.ReadLine();
	Console.WriteLine($"Digite o EMAIL do estudante {i + 1} : ");
	string email = Console.ReadLine();
	Console.WriteLine($"Digite o n° do QUARTO do estudante {i + 1} : ");
	int roomNumber = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

	vector[i] = new Student { Name = name, Email = email, RoomNumber = roomNumber };
}

void Print()
{
    Console.WriteLine("***********************************************************");
    Console.WriteLine("");
    Console.WriteLine("Relatório de ocupações do pensionato: ");
	Console.WriteLine("Quantos quartos serão alugados? " + n);
    Console.WriteLine("");
    for (int i = 0; i < n; i++)
	{
        Console.WriteLine("Aluguel #" + (i + 1));
        Console.WriteLine("Nome: " + vector[i].Name);
		Console.WriteLine("Email: " + vector[i].Email);
		Console.WriteLine("Quarto: " + vector[i].RoomNumber);
		Console.WriteLine("");
	}

    Console.WriteLine("Quartos ocupados: ");
	for (int i = 0; i < n; i++)
	{
		Console.WriteLine(vector[i].RoomNumber + ": " + vector[i].Name + ", " + vector[i].Email);
    }

}

Print();