using static System.Console;

Write("Введите число: ");
int a = int.Parse(ReadLine()!);
int n = 1; 

while (n <= a ) 
{
    if (n % 2 == 0)
    Write($"{n} ");
    n++;   
}
