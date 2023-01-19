// Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и тд.
//Результат запишите в новом массиве.


using static System.Console;
Clear();

int[] array = GetArray(10); // создаем массив 5ти размерным
PrintArray(array);         // печатаем
int[] array2 = multiPara(array); // через функцию производим сложение 
PrintArray(array2);       // снова печатаем

int [] GetArray(int size)
{
    int[] resultArray = new int [size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
       resultArray[i] = random.Next(0,10);
    }
    return resultArray;
}


int[] multiPara(int[] array)
{
    int size = array.Length / 2; //  определяем размер деленное на 2 идем на встречу друг другу
    if(array.Length % 2 == 1) size++;//если у нас не четное добавляем середину увеличиваем на 1
    
    int[] result = new int [size];// создаем новый массив
    for (int i = 0; i < size; i++)
    {
        result [i] = array [i] * array[array.Length -i -1];// наполняем массив 
    }  // первоt числo array [i] умножаем на число с другой стороны array[array.Length -i -1]
    return result;// возврящаем результат 
}


void PrintArray(int[] inArray) // inArray название переменной
{
    Write("[");
    for (int i = 0; i < inArray.Length -1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    WriteLine($"{inArray[inArray.Length-1]}]"); //Что бы последний элемент был без запятой
}