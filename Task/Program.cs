using static System.Console;

WriteLine("Введитечисло: ");

int a = int.Parse(ReadLine()!);
//int b = Convtrt.ToInt32(ReadLine());
WriteLine($"Квадрат числа {a} равен {a*a}");