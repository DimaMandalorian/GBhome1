// еще проверка 
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

