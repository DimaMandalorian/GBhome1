//  метод Написать программу которая создаст массив со случайными цифрами
// и развернет его
// как выводить массив в строку. Изучаем Класс String Метод Join два параметра
//первый это разделитель "," "#" "|" второй это массив который мы выводим 
// только для одномерных массивов


using static System.Console;
Clear();

Write("Введите размер массива: "); 
int arraySize = int.Parse(ReadLine()!);// всталяем число в консоли, длинну массива 
int [] array = GetArray(arraySize); // формируем массив  результат выполнения метода arraySize

// выводим числа массива через запятую 
WriteLine($"[{String.Join(",", array)}]"); 

//выводим метод реверса ReverseArray в качестве входного параметра наш массив array
//WriteLine($"[{String.Join(",",ReverseArray(array))}]"); // вернет массив который выведем в 
//следующей строке 

ReverseArray2(array);
WriteLine($"[{String.Join(",", array)}]");



int[] GetArray(int size) // метод один параметр size
{
    int[] resultArray = new int[size]; // создаем массив 
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(1,10);
    }
    return resultArray; // возвращаем массив
}

// Метод реверс array массива, на базе существующего и выводит созданный массив и его реверс
int [] ReverseArray(int [] inArray) // в качестве входного параметра наш массив
{
    int[] result = new int[inArray.Length]; // создаем новый массив, размер которого такой же
                                            // как у входного нашего массива
    for (int i = 0; i < inArray.Length; i++)// проходимся по массиву
    {
        result[i] = inArray[inArray.Length - 1 - i];// проходим исходный массив и 
        // подкладываем с конца в начало по порядку
    }
    return result; // возврат массива 
}

//Метод не возвращает и выводит на экран только реверс созданного массива
void ReverseArray2(int [] inArray) // в качестве входного параметра наш массив
{   // проходимся по массиву до середины чтобы не развернуть его обратно как было
    for (int i = 0; i < inArray.Length/2; i++)
    {
        //  промежуточная переменная int temp помещаем туда inArray[i]=стартовое значение
        int temp = inArray[i];
        
        // помещаем значение которое находится в конце в первую переменную
        inArray[i] = inArray[inArray.Length - 1 - i];

        // то что лежало в начале кладем то что было в конце
        inArray[inArray.Length - 1 - i] = temp;
    }
}




// метод помогает вывести числа в масиве через пробел, запятую, решетку либо что укажем 
// string stringArray = String.Join("#", array);
// WriteLine($"[{stringArray}]");