using ExercRes01.Entities;
using ExercRes01.Entities.Enums;
using System.Threading.Channels;
using System.Globalization;

Console.Write("Enter department's name: ");
string deptName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior, MidLevel or Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// As variáveis abaixo irão instanciar os objetos dept e worker na memória
Department dept = new Department(deptName);
Worker worker = new Worker(name, level, baseSalary, dept);

Console.Write("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data: ");

    Console.Write("Date (DD/MM/YYYY): ");
	DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

	Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());

    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);
    
}

Console.WriteLine();
Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string incomeDate = Console.ReadLine();

int incomeYear = int.Parse(incomeDate.Substring(3));
int incomeMonth = int.Parse(incomeDate.Substring(0, 2));



Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department.Name);
Console.WriteLine("Income for " + incomeDate + ": " + worker.Income(incomeYear, incomeMonth));
























