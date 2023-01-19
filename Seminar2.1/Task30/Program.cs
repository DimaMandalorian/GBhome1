//Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных
// элементов массива.


using static System.Console;
Clear();


//считать несколько элементов из одной строки
Write($"Введите размер массива, мин и мах через пробел:");
// разбиваем строку на подстроки
string[] parameters=ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//метод Split позволяет разбить строку на подстроки по указанному разделителю()
//получаем массив строк который получится при разбиении одной строки на пробелы
//получим массив из 3х строк в которых будут лежать наши числа
//StringSplitOptions.RemoveEmptyEntries = позволяет удалить лишие пробелы(пустые элементы)

WriteLine(parameters.Length);
int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
// int array это=GetArray(int.Parse(размер массива),минимальное значение, максимальное значение)
PrintArray(array);

WriteLine(); // вывод положительных и отрицательных с новой строки
// сумма положительных и отрицательных элеменов массива
int negativeSum=0; // отрицательна сумма 
int positiveSum=0; // 
// циклическая конструкция foreach позволяет опросить все элементы входного массива
// переменная (var) сама определит какого типа у нас массив int? string? или что то еще
foreach(var element in array) // это от 0 до конца массива каждый раз в переменную (а) подкладывает                       
{                       //новое значение массива. Переменную (а) нельзя менять!!!
    negativeSum += element < 0 ? element:0; // сумма отрицательных значение
    positiveSum += element > 0 ? element:0; // сумма положительных значений
}
WriteLine($"{negativeSum}  {positiveSum}");// вывод значения элементов 

// метод формирования массива указанного размера,в указанном диапазоне чисел
// int[] в результате метода получим массив, если просто число то без скобок


int[] GetArray(int size, int minValue, int maxValue)//целочисленный массив(передаем в него 3 параметра)
{ //size (размер), minValue(минимальное значение),maxValue (максималтное значение)
    int[] resultArray = new int[size];// создаем массив = с новой переменной new int размером size
    Random rnd = new Random();// генератор чисел
    for (int i = 0; i < size; i++) //цикл размер указан size
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);//захватим последний элемент (maxValue + 1)
    }
    return resultArray;
}
//метод Выводим на печать красиво в квадратных ковычках через запятые
void PrintArray(int[] inArray) // inArray название переменной
{
    Write("[");
    for (int i = 0; i < inArray.Length -1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}]"); //Что бы последний элемент был без запятой
}


//координаты
// Clear();
// Write("Ведите кор А через пробел: ");
// Point A = GetPointFromString(ReadLine()!);
// Write("Ведите кор B через пробел: ");
// Point B = GetPointFromString(ReadLine()!);

// double delta = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2) + Math.Pow(A.Z - B.Z, 2));
// WriteLine(delta);



// Point GetPointFromString(string inStr)
// {
//     Point res = new Point();
//     string[] par = inStr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//     res.X = int.Parse(par[0]);
//     res.Y = int.Parse(par[1]);
//     res.Z = int.Parse(par[2]);
//     return res;
// }


// struct Point
// {
//     public int X;
//     public int Y;
//     public int Z;
// }

// struct MyStruct
// {
//     public int ArrayValue;
//     public int ArrayIndex;
// }