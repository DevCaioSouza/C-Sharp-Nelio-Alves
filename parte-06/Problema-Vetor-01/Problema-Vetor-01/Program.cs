using System.Globalization;

Console.Write("Digite o número total de pessoas da amostra: ");
int n = int.Parse(Console.ReadLine());

double[] vetor = new double[n];

for(int i = 0; i < n; i++)
{
	vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double sum = 0.0;

for (int i = 0; i < n; i++)
{
	sum += vetor[i];
}

double result = sum / n;

Console.WriteLine("A média das alturas das " + n + " pessoas é: " + result.ToString("F2", CultureInfo.InvariantCulture));