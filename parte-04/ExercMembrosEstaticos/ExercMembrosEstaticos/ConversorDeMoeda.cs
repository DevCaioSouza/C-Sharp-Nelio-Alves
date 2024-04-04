//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ExercMembrosEstaticos
{
	internal class ConversorDeMoeda
	{
		public double ValorDoDolar;
		public double QuantosDolares;

		public double PagoEmReais(double valorDoDolar, double quantosDolares)
		{
			return valorDoDolar * quantosDolares;
		}
		public double CalcularImpostos(double valorEmReais)
		{
			return valorEmReais * 6 / 100;
		}
	}
}
