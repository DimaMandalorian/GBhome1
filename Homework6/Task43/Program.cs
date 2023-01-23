// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();


Write("значение -> b1: ");
int.TryParse(ReadLine(), out int b1);
Write("Значение -> k1: ");
int.TryParse(ReadLine(), out int k1);
Write("Значение -> b2: ");
int.TryParse(ReadLine(), out int b2);
Write("Значение -> k2: ");
int.TryParse(ReadLine(), out int k2);
GetPoint(k1,b1,k2,b2);


//WriteLine (GetPoint(k1,b1,k2,b2)? $"Не пересекаются!" : $"Точка пересечения ->({x}; {y})");
//Write("Не пересекаются.");
//Write($"Точка пересечения: ({x};{y})");


void GetPoint(double k1, double b1, double  k2, double b2) 
{
    if ((b1 * k2 - b2 * k1) == 0 || (k1 * k2 + b1 * b2) == 0) //return;  //if(b1==b2 || k1==k2) 
    {
       Write("Не пересекаются!");
    }
    else 
    {
        double x, y;
        x = (b1-b2)/(k2-k1);
        y = (k2*b1-k1*b2)/(k2-k1);
        Write($"Точка пересечения->({x}; {y})"); 
    }
    //return;
}


// Не мое решение
// double[] arr = IntersectionPoint (k1, b1, k2, b2);
// WriteLine($"({String.Join("; ", arr)})");

// double [] IntersectionPoint (double a, double c, double b, double d)
// {
//     double[] array = new double [2];
//     array[0] = (c - d)/(b - a);
//     array[1] = b *((c - d)/(b - a)) + d;
//     return array;
// }