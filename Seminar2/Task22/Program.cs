﻿// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N.

using static System.Console;
Clear();
int i = 1;

Write("Введите число для вывода таблицы квадратов от 1 до числа: ");
int.TryParse(ReadLine(),out int n);

// for (i=1; i<n+1; i++)
// {
//     WriteLine($"Квадрат числа {i} = {Math.Pow(i,2)}");
// }

while (i <n+1)
{
    WriteLine($"Квадрат числа {i} = {Math.Pow(i,2)}");
    i++;
}