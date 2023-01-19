//Программа замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные и наоборот
// [-4,-8,8,2] -> [4,8,-8,-2]

using static System.Console;
Clear();

int[] array = { -4, -8, 0, 8, 2};

ReversArray(array);
PrintArray(array);

void ReversArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)//проходим от нуля до конца длинны массива
    {
        inArray[i]*= -1; // перезаписываем значение элемента меняем + на - и наоборот
    }
}

void PrintArray(int[] inArray)// метод выводим в консоль 
{
    Write("[");
    for (int i = 0; i < inArray.Length -1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    WriteLine($"{inArray[inArray.Length - 1]}]");
}