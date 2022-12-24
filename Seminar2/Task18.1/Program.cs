using static System.Console;
Clear();

Write("Введите число четверти: ");
int x=int.Parse(ReadLine()!);
Write("Введите число четверти: ");
int y=int.Parse(ReadLine()!);

WriteLine("");
WriteLine("Четверти:");
WriteLine(" II I ");
WriteLine("III IV");
WriteLine("");

if (x==0 || y==0)
{
    WriteLine("Error");
    return;
}
if (x>0 && y>0)
{
    WriteLine("I четверть");
    return;
}
if (x<0 && y>0)
{
    WriteLine("II четверть");
    return;
}
if (x<0 && y<0)
{
    WriteLine("III четверть");
    return;
}
if (x>0 && y<0)
{
    WriteLine("IV четверть");
    return;
}
