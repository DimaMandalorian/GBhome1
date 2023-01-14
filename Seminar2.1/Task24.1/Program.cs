//Программа принимает на вход число 
// на выходе количество цифр в числе.
// 456 -> 3   78->2  89126 ->5

using static System.Console;
Clear();

Write("Input number: " );      // Вводим число      
int.TryParse(ReadLine(), out int number); // Проверяем что оно может быть числом 
                        // Если это число]]]]]]]]6 то присваеваем его к переменной number

WriteLine($"Количество цифр в числе {number} -> {NumCount(number)}"); // через WriteLine 
// обращаемся к методу NumCount в которую передаем переменную number




int NumCount(int num) // метод принимает int num
{
    int digits = 0; // вводим отдельную переменную которая пока = 0
    while(num > 0) // проверяем пока (num > 0)
    {
        digits++; //увеличиваем эту переменную на 1
        num /=10; //каждый раз при делении уменьшается на 1 цифру
    }
    return digits;
}

