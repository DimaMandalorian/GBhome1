// Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат 
//в отрезке [10,99]

using static System.Console;
Clear();

Write("Введите начальное значение отрезка: ");
int start = int.Parse(ReadLine()!);

Write("Введите конечное значение отрезка: ");
int finish = int.Parse(ReadLine()!);

int[] array = GetArray(123);
int countInArray = findCountNumberInArray(array, start, finish);
Write("Количество найденных элементов в массиве: ");
PrintArray(array);
WriteLine($" равно {countInArray}");

int [] GetArray(int size)
{
    int [] resultArray = new int [size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(0,1000);
    }
    return resultArray;
}

int findCountNumberInArray(int[] array, int start, int finish)
{
    int result = 0;
    foreach (var i in array)
    {
        if(start <= i && i <= finish) result++;
    }
    return result;
}

void PrintArray(int[] inArray) // inArray название переменной
{
    Write("[");
    for (int i = 0; i < inArray.Length -1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}]");
}

// ВАРИАНТ 2
// using static System.Console;
// Clear();

// int[] array =GetArray(12, 10, 99);
// PrintArray(array);
// WriteLine();
// WriteLine(ArrayCount(array));



// int ArrayCount(int[] InArray)
// {
//     int result = 0;
//     foreach(int i in InArray)
//     {
//         if (10 <= i && i <= 99) result ++;
//     }
//     return result;
// }

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] resultArray = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         resultArray[i] = rnd.Next(minValue, maxValue + 1);
//     }
//     return resultArray;
// } 

// void PrintArray(int[] inArray) // inArray название переменной
// {
//     Write("[");
//     for (int i = 0; i < inArray.Length -1; i++)
//     {
//         Write($"{inArray[i]}, ");
//     }
//     Write($"{inArray[inArray.Length-1]}]"); //Что бы последний элемент был без запятой
// }
