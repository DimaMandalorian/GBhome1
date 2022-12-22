using static System.Console;

Write("Введите число: ");
int a = int.Parse(ReadLine()!);


if(a<99)
{
     WriteLine("третьей цифры нет");
}
else
{
WriteLine(a%10);
}
