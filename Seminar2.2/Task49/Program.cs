// Задайте двумерный массив. Найдите элементы,
// у которых оба индекса четные, и замените 
// эти элементы на их квадраты.
// Начальный массив 
// 1 4 7 2
// 5 9 2 3 
// 8 4 2 4 
// будет выглядеть так 
// 1 4 7 2 
// 5 81 2 9
// 8 4 2 4 

using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters=ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[,] array=GetMatrixArray(int.Parse(parameters[0]),int.Parse(parameters[1]),int.Parse(parameters[2]),int.Parse(parameters[3]));
PrintMatrixArray(array); // вводим в печать первый массив 

int[,] matrix = newMatrix(array); // создаем новый двумерный массив с результатом 

WriteLine(); // Разделить матрицы 

PrintMatrixArray(matrix); // выводим в печать результат новый масив 

// создаем двумерный масси с рондомными числами
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
// результат новый массив 
int[,] newMatrix(int[,] array)// на вход принимает массив
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++) // перебираем строки
    {
        for (int j = 0; j < array.GetLength(1); j++) // перебираем столбы
        {  // проверяем i строки если он четный и не равен 0
           // проверяем j столбца если он четный и не равен 0 
            if ((i % 2 == 0 && i != 0) && (j % 2 == 0 && j != 0)) 
            {   // тогда число  возводим в квадрат
                newArray[i, j] = array[i, j] * array[i, j]; 
            }
            else
            { // если не совпало оставляем как есть
                newArray[i, j] = array[i, j];
            }
        }
    }
    return newArray;
}

// Второй Вариант точечно меняем нужный элемент возводим в квадрат
// PrintMatrixArray (array);
// EvenElementsPow2(array);
// WriteLine("");
// WriteLine("");
// PrintMatrixArray (array);

// без изменения существующего массива 
// void  EvenElementsPow2(int[,] inArray);
// {   // Начинаем сразу со второго элемента int i = 2
//     for (int i = 2; i < inArray.GetLength(0); i+=2)
//     {                                      // i+=2 перескакиваем через 1 элемент в строке
//         for (int j = 2; j < inArray.GetLength(1); j+=2)
//         {                                   // j+=2 перескакиваем через 1 элемент в столбце
//             inArray[i,j] *= inArray[i,j];
//         }
//     }
// }