// Задайте двумерный массив размером m; x;
// заполненный случайными целыми числами
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1 

using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: "); // вводим параметры
//считываем параметры из сторики 
// Массив одного типа преобразовать в другой(string[] перевести в int[])
//int[] intParams=Array.ConvertAll(parametrs,int.Parse); //  или Convert.ToInt32
int[] intParams=Array.ConvertAll(ReadLine()!.Split(new char[]{'\"','#',';','s'},StringSplitOptions.RemoveEmptyEntries),int.Parse); 

int[,]array = GetMatrixArray(intParams[0],intParams[1],intParams[2],intParams[3]); 
                            
// считываем параметры из сторики 
//string[] parametrs = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
// cоздали двумерный масив
// int[,]array = GetMatrixArray(int.Parse(parametrs[0],int.Parse(parametrs[1],
//                              int.Parse(parametrs[2],int.Parse(parametrs[3]); 
                                // количество строк[0], количество столбцов [1]
                            // минимальное значение[2], максимальное значение[3]

PrintMatrixArray(array); // выводим матрицу в консоль, печатаем

// выыодимый тип int[,] имя массива GetMatrixArray и параметры
int[,] GetMatrixArray(int row, int columns, int minValue, int maxValue)
{// row количество строк, columns количество стобцов,(int minValue, int maxValue) диапазон значений
    Random rnd = new Random();
    // формируем новый массив int[,] resultArray поэлементно
    int[,] resultArray = new int[row, columns];//входной параметрт строки и столбцы
    for (int i = 0; i < row; i++) // формируем строки
    {
        for (int j = 0; j < columns; j++) // формируем столбцы 
        {
            resultArray[i,j] = rnd.Next(minValue, maxValue+1); // заполняем массив
        }                                // +1 захватить крайний диапазон чтобы числа вошли
    }
    return resultArray; // возвращаем результат
}
   

// метод вывода матрицы в консоль PrintMatrixArray - имя матода
void PrintMatrixArray (int[,] inArray) // входной параметр двумерный массив
{    // проходимся по строкам (0)строки это стартовый параметр сколько строк в матрице
    for (int i = 0; i < inArray.GetLength(0); i++) 
    {    // проходимся по столбцам (1) второй параметр
        for (int j = 0; j < inArray.GetLength(1); j++)
        {   // под каждый элемент матрицы выделяем (3 символа) чтобы матрица была ровной
            Write($"{inArray[i,j],5} "); //выводим строку
        }
        WriteLine(); // с новой строки 
    }   
} 

// массив позволяет сразу получить массив чисел из строки
// Массив одного типа преобразовать в другой(string[] перевести в int[])
// у класса Array есть метод какой Array.ConvertAll он позволяет преобразовать элементы 
//одного массива в другой. На вход принимает 1 параметр (parametrs,) а 2 параметр говорит
// какой закон применить к каждому элементу внутри первого массива (Convert.ToInt32) или 
// (int.Parse)
// int[] intParams=Array.ConvertAll(parametrs,Convert.ToInt32) //int.Parse
//                 parametrs входной параметр, Convert.ToInt32 выходной параметр закон применения