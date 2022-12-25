//  Напишите программу, которая принамает на вход координаты точек
// и находит расстояние между ними в 2D пространстве.


using static System.Console;
Clear();

Write("Точка A -> Введите координату x: ");
int.TryParse(ReadLine(), out int ax);
Write("Точка A -> Введите координату y: ");
int.TryParse(ReadLine(), out int ay);
Write("Точка B -> Введите координату x: ");
int.TryParse(ReadLine(), out int bx);
Write("Точка B -> Введите координату y: ");
int.TryParse(ReadLine(), out int by);

double length = Math.Sqrt(Math.Pow((ax-bx),2)+Math.Pow((ay-by),2));
WriteLine(length);