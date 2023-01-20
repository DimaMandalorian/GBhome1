// Напишите программу реализующую методы формирования массива,
// заполненного случайными положительными трёхзначными числами, 
// и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();


int [] arr = GetArray(4); 

PrintArray(arr);

int arr2 = GetSum (arr);
WriteLine($" -> {arr2}");

int GetSum (int [] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) res++;
    }
    return res;
    //WriteLine($" -> {res}");
}
// int res = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] % 2 == 0) res++;
// }
// WriteLine($" -> {res}");



int[] GetArray (int size)  
{
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(100,999); 
    }
    return array; 
}



void PrintArray(int[] inArray) 
{
    Write("[");
    for (int i = 0; i < inArray.Length -1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}]");
}