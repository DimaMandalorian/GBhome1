// программа принимает на вход число N 
// на выходе произведение чисел от 1 до N.
// 4 -> 24   5 -> 120



using static System.Console;
Clear();

Write("Input number: " );            
int.TryParse(ReadLine(), out int number);
WriteLine($"Произведение ряда чисел от 1 до {number} = {NumProduct(number)}");




int NumProduct(int num)
{
    int result = 1;
    while(num > 0)
    {
        result *= num;
        num--;
    }
    return result;
}
