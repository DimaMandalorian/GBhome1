﻿// Задайте двумерный массив. Найдите сумму элементов
// находящихся на главной диагонали (с индексами(0,0) (1,1) и т.д.)
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// сумма элементов диагонали 1+9+2=12

using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[,] array=GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]),int.Parse(parameters[2]),int.Parse(parameters[3]));
PrintMatrixArray(array);

int result = newMatrix(array);

WriteLine($"Сумма: {result}");

WriteLine();


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd=new Random();
    int[,] resultArray=new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j]=rnd.Next(minValue,maxValue+1);
        }
    }
    return resultArray;
}


void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j],5} ");
        }
        WriteLine();
    }
}

int newMatrix(int[,] array)// на вход принимает массив
{
    int sum = 0;
    for (int i = 0; i < (array.GetLength(0) < array.GetLength(1)? 
                        array.GetLength(0):array.GetLength(1)); i++)
    {
        sum += array[i,i];
    }
    return sum;
}