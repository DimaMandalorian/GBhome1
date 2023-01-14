// Программа которая выдает сумму чисел от 1 до N
// на которые N делится без остатка

using static System.Console;
Clear();

Write("Input number: " );            
int.TryParse(ReadLine(), out int number);
WriteLine($"Произведение ряда чисел от 1 до {number} = {NumProduct(number)}");



int NumProduct(int num)
{
    int result = 0;
    int temp = num;
    while(num > 0)
    {
        if (temp % num == 0)
        {
            result += num;
        }    
        num--;
    }
    return result;
}