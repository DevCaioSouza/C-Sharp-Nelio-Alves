using System.Globalization;

Console.Write("Quantos elementos terá o vetor? ");
int n = int.Parse(Console.ReadLine());

double[] vetor = new double[n];

for(int i = 0; i < n; i++)
{
    Console.Write("Nome do item: ");
    Console.ReadLine();
	Console.Write("Preço do item: ");
	vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double sum = 0;

for (int i = 0; i < n; i++)
{
	sum += vetor[i];
}

double avg = sum / n;

Console.WriteLine("Preço médio dos itens: " + avg.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Fim do programa!");