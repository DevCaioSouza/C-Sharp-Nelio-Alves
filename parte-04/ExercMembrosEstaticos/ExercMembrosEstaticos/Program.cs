

using ExercMembrosEstaticos;

ConversorDeMoeda Conversor = new ConversorDeMoeda();

Console.Write("Digite a cotação do dólar: ");
Conversor.ValorDoDolar = double.Parse(Console.ReadLine());

Console.Write("Quantos dólares você deseja comprar? ");
Conversor.QuantosDolares = double.Parse(Console.ReadLine());

double Resultado = Conversor.PagoEmReais(Conversor.ValorDoDolar, Conversor.QuantosDolares);

Console.WriteLine("Valor a ser pago em reais pela aquisição:  " + Resultado);

double Impostos = Conversor.CalcularImpostos(Resultado);

Console.WriteLine("IOF descontado: " + Impostos);

//Console.WriteLine(Resultado);




