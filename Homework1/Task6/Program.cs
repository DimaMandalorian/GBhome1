using static System.Console;

Console.Write("Введитe число ");
int n = int.Parse(Console.ReadLine()!);

if (n % 2 == 0) 
   {WriteLine("да");}
else
   {WriteLine("нет");}