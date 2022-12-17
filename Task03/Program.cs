//Напишите программу, которая выдает название дня недели по заданному номеру.
//1 -> понедельник
//7 -> воскресенье 
using static System.Console;

Write("Введите число от 1 до 7: ");
int a = int.Parse(ReadLine());

if (a == 1)
    {
    WriteLine("понедельник");
    }
        else if (a == 2)
        {
        WriteLine("Вторник");
        }
            else if (a == 3)
            {
            WriteLine("среда");
            }
                else if (a == 4)
                {
                WriteLine("четверг");
                }
                    else if (a == 5)
                    {
                    WriteLine("пятница");
                    }
                        else if (a == 6)
                        {
                        WriteLine("суббота");
                        }
                            else if (a == 7) { WriteLine("воскресение"); }
else {
    WriteLine("Введено не верное число");
}
