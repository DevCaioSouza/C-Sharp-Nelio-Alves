
//Fazer um programa para ler um número inteiro N e uma matriz de
//ordem N contendo números inteiros. Em seguida, mostrar a diagonal
//principal e a quantidade de valores negativos da matriz.

int N = int.Parse(Console.ReadLine());

int[,] matriz = new int[N, N];

for (int i = 0; i < N; i++)
{
	string[] values = Console.ReadLine().Split(" ");

	for (int j = 0; j < N; j++)
	{
		matriz[i, j] = int.Parse(values[j]);
	}
}

Console.WriteLine("Diagonal principal: ");
for (int i = 0; i < N; i++)
{
	Console.Write(matriz[i, i] + " ");
}
Console.WriteLine();

Console.WriteLine("Valores negativos da matriz: ");
for (int i = 0; i < N; i++)
{
	for (int j = 0; j < N; j++)
	{
		if (matriz[i, j] < 0)
		{
			Console.Write(matriz[i, j] + " ");
		}
	}
}

