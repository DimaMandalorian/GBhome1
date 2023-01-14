//Методы
using static System.Console;
//Принимаем на вход число А, на выходе 
// сумма чисел от 1 до А.

Clear();
Write("Input number1: " ); // просим введите число
int namber1 = int.Parse(ReadLine()!); // Считываем некое число введенное с консоли

int sum1 = GetSum(namber1); // некая сумма (int sum) которая получитася в результате 
                        // выполнения метода GetSum(namber) в качестве входного 
                        //парметра Будет число namber 
                        //и программа будет искать подпрограмму основогого кода
WriteLine($"Sum number 1..A = {sum1}"); // ответ сумму выводим на экран в консоль
// сумма числа А, Sum number от 1 до А = {sum}

Write("Input number2: " );            // метод int GetSum(int A) уже написан
int namber2 = int.Parse(ReadLine()!);  // сейчас можно только к нему обращаться 
int sum2 = GetSum(namber2);             //сколько нужно раз
WriteLine($"Sum number 1..A = {sum2}"); 

// имя метода
int GetSum(int A)  // метод принимает сумм, (сумму числа А)
{                   // число положеное в скобки примет как переменная А=namber
    int result=0; // начальная сумма равна 0
    while(A>0)    // пока А больше 0 (будем вычитать 1)
    {
        result += A; // цикл сумма от 1 до А
        A--; // декримент А - 1 сократили А на единицу
    }
    return result; // возвращвет сумму 
}   // на выходе int GetSum будет равен return result

