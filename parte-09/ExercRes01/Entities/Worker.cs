using ExercRes01.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercRes01.Entities
{
	internal class Worker
	{
		public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

		//Precisamos declarar uma prop contendo as classes secundárias
		//É assim que fazemos a associação das classes na composição
		public Department Department { get; set; } 
		//No caso dos Contracts usamos uma List pq é uma relação de 1 Worker p/ muitos Contratos
		public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

		public Worker(string name, WorkerLevel level, double baseSalary, Department department)
		{
			Name = name;
			Level = level;
			BaseSalary = baseSalary;
			Department = department;
			// No caso de Contracts, não incluímos no construtor pq é uma associação 1 p/ muitos
		}

		public void AddContract(HourContract contract)
		{
			Contracts.Add(contract);
		}

		public void RemoveContract(HourContract contract)
		{
			Contracts.Remove(contract);
		}

		public double Income(int year, int month)
		{
			double sum = BaseSalary;

			foreach (HourContract contract in Contracts)
			{
				if(contract.Date.Year == year && contract.Date.Month == month)
				{
					sum += contract.TotalValue();
				}
			}
			return sum;
		}
	}
}
