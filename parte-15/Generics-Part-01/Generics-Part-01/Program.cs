// See https://aka.ms/new-console-template for more information

using Generics_Part_01.Services;

PrintService printService = new PrintService(); 

Console.Write("How many values?");
//Console.ReadLine();

int n = int.Parse(Console.ReadLine());



for(int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    printService.AddValue(x);    
}

printService.Print();

Console.Write("First: ");
Console.WriteLine(printService.First());





