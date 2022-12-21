using static System.Console;

WriteLine("Введите первое число a: ");
int number1 = Convert.ToInt32(ReadLine());

WriteLine(number1 % 7 == 0 && number1 % 23 == 0? "кратно": "некратно");