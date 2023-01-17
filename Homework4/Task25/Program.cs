// Программа принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В
// используем цикл 3,5 ->2 43  2,4 ->16



using static System.Console;
Clear();

Write("Input A: " ); 
int A = int.Parse(ReadLine()!);
Write("Input B: " );
int B = int.Parse(ReadLine()!);
int sum = GetSum(A);
WriteLine($"Результат -> {sum}");



int GetSum(int A)
{
    int sum = A;
    for (int i = 1; i < B; i++)
    {
        sum *= A;
    }
    return sum;
}



// using static System.Console;
// Clear();

// Write("Input A: " ); 
// int A = int.Parse(ReadLine()!);
// Write("Input B: " );
// int B = int.Parse(ReadLine()!);



// int sum = A;
// for (int i = 1; i < B; i++)
// {
//     sum *= A;
// }
// WriteLine($"Результат -> {sum}");