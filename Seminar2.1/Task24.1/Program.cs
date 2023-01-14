//Программа принимает на вход число 
// на выходе количество цифр в числе.
// 456 -> 3   78->2  89126 ->5

using static System.Console;
Clear();

Write("Input number: " );            
int.TryParse(ReadLine(), out int number);
WriteLine($"Количество цифр в числе {number} -> {NumCount(number)}");




int NumCount(int num)
{
    int digits = 0;
    while(num > 0)
    {
        digits++;
        num /=10;
    }
    return digits;
}

