// Напишите программу, реализующую метод, который формирует 
// массив случайных целых чисел из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

using static System.Console;
Clear();

int [] arr = GetArray(8); //размер массива из скольки то элементов
PrintArray(arr);


int[] GetArray (int size)  // метод
{
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++) // перебираем каждый элемент массива
    {
        array[i] = new Random().Next(1,99); // заменяем элемент,случайные числа от 1 до 99
    }
    return array; // не совсем уяснил
}

void PrintArray (int [] array) // что это я не понял
{
    for (int i = 0; i < array.Length; i++) // добавляем новое число в элемент массива
    {
        Write($"{array[i]}, "); // показать в терминале
    }
    Write ($"{array[array.Length-1]}");

}