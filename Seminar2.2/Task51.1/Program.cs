// Шахматная доска 1я клетка черная
// на вход координата и цвет клетки
// шахматная доска. (abcd... 1234 ... a1,a2)
// не вносим в массив всю доску шахматную
// сделать красиво




using static System.Console;
Clear();
// считываем два параметра
Write("Вводим координаты клетки: ");

// string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
// int par1 = char.Parse(parameters[0]);// буква
// int par2 = int.Parse(parameters[1]);// цифра

string parameters = ReadLine();
int par1 = parameters[0]; 
int par2 = parameters[1];

string p1 = parameters[0].ToString();
WriteLine($"text ={p1}");

// char letter = 'A';
// int letterint = letter;
WriteLine(par1);
WriteLine(par2);

if ((par1+par2)%2 !=0) // Сумма чисел на процент от деления != не равно 0
{
    WriteLine("Белая"); // если четная то белая
}
else
{
    WriteLine("Черная");// если не четная то черная
}