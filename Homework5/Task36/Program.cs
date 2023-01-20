// Напишите программу реализующую методы формирования массива, 
// заполненного случайными числами и подсчета суммы элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

int [] arr = GetArray(4); 
PrintArray(arr);



int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if ( i % 2 == 0) // положительные индексы массива
    {      
        sum += arr[i];   
    }
}
WriteLine($" -> {sum}");




int[] GetArray (int size)  
{
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,99); 
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
