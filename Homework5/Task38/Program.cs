// Напишите программу реализующую методы формирования массива, 
// заполненного случайными вещественными числами и вычисления 
// разницы между максимальным и минимальным элементов массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76


using static System.Console;
Clear();

int [] arr = GetArray(10); 
PrintArray(arr);




int min = arr[0];
int max = arr[0];
//foreach (var i in arr)             // не получается  foreach 
for (int i = 1; i < arr.Length; i++)
{
    max = arr[i] < max ? max:arr[i];
    min = arr[i] > min ? min:arr[i];
}
WriteLine($" -> {max - min}");


//for (int i = 1; i < arr.Length; i++)
// {
//     if(arr[i] < min)
//     {
//         min = arr[i];
//     }
//     if(arr[i] > max)
//     {
//         max = arr[i];
//     }
// }
//WriteLine($" -> {max - min}");


int[] GetArray (int size)  
{
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(1,99); 
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