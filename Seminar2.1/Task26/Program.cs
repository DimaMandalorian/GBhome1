//Программа которая выводит массив из 8 элементов
//заполненный нулями и единицами в случайном проядке.
// [1,0,1,1,0,1,0,0]

using static System.Console;
Clear();

int [] arr = GetArray(8);

PrintArray(arr);

void FullArray (int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

int[] GetArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
}