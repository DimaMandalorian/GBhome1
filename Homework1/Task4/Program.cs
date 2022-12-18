using static System.Console;

WriteLine("Максимальное из трех чисел");
Write("Введите число a: ");
int a = int.Parse(ReadLine()!);
Write("Введите число b: ");
int b = int.Parse(ReadLine()!);
Write("Введите число c: ");
int c = int.Parse(ReadLine()!);

if (a>b && a>c)
{WriteLine(a);}
else
    if (b>c)
    {WriteLine(b);}
    else
        {WriteLine(c);}