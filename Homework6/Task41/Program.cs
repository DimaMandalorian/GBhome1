//Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2     1, -7, 567, 89, 223-> 3


using static System.Console;
Clear();


int[] array = { 0, 7, 8, -2, -2};
PrintArray(array);

int positiveCount = 0;
positiveCount = array.Count(i => i > 0);
Write($" -> {positiveCount}");

void PrintArray(int[] inArray) 
{
    for (int i = 0; i < inArray.Length -1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}");
}


// int[] array = { 1, -7, 567, 89, 223};
// //int negativeCount = 0; 
// int positiveCount = 0;
// //negativeCount = array.Count(x => x < 0);
// positiveCount = array.Count(i => i > 0);
// //for (int i = 0; i < array.Length; i++)
// //{
// //    if (array[i] < 0) negativeCount++;
// //    else if (array[i] > 0) positiveCount++;
// //}
// Write($"-> {positiveCount}");
// //Console.ReadKey();            
