using static System.Console;

Console.Write("Введитe число ");
int n = int.Parse(Console.ReadLine()!);
double n_2 = n % 2;
if (n_2==0) 
    WriteLine("да");
else
WriteLine("нет");