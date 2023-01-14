// программа принимает на вход число N 
// на выходе произведение чисел от 1 до N.
// 4 -> 24   5 -> 120



// using static System.Console;
// Clear();

// Write("Input number: " );            
// int.TryParse(ReadLine(), out int number);
// WriteLine($"Произведение ряда чисел от 1 до {number} = {NumProduct(number)}");




// int NumProduct(int num)
// {
//     int result = 1;
//     while(num > 0)
//     {
//         result *= num;
//         num--;
//     }
//     return result;
// }

// второе решение если число отрицательное

using static System.Console;
Clear();

Write("Input number: " );            
int n = int.Parse(ReadLine()!);

WriteLine($"product 1..n = {GetMult(n)}");




int GetMult(int A)
{
    if(A <= 0) return 0;

    int result = 1;
    while(A > 0)
    {
        result *= A;
        A--;
    }
    return result;
}
