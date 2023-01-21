//  Не используя рекурсию, выведите первые N чисел
// Фибоначчи.Первые два числа Фибоначчи 0 и 1
// N = 5 -> 01123  N = 3 -> 011  N = 7 -> 0112358

using static System.Console;
Clear();

// решение без массивов
Write("Введите число: ");
int number = int.Parse(ReadLine()!); 
Fibonacci(number);  // метод

void Fibonacci(int number) // метод
{
    int temp, num1 = 0,num2 = 1; //Временная переменнаяtemp, 
    //первое число Фибоначчи num1 = 0, второе число Фибоначи num2 = 1;

    Write($"{num1}{num2}"); // выводим первые 2 числа
    for (int i = 2; i < number; i++)// начинаем с элемента индекс 2
    {
        temp = num1 + num2; 
        num1 = num2;
        num2 = temp;
        Write($"{num2}");
    }
}







 

// int AskUserForNamber(string inPromt)
// {
//     int resultNum = 0;
//     string userInput = "";
//     while (!int.TryParse(userInput, out resultNum))
//     {
//         Console.Write(inPromt);
//         userInput = Console.ReadLine()!;
//     }
//     return resultNum;
// }