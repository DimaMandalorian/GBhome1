// программа принимает на вход три числаи проверяет
// может ли существовать треугольник со сторонами такой длинны
// существует или не существует

using static System.Console;
Clear();
// треугольник
int a = AskUserForNamber("Введите сторону треугольника a: "); // длинна стороны а
int b = AskUserForNamber("Введите сторону треугольника b: "); // длинна стороны в
int c = AskUserForNamber("Введите сторону треугольника c: "); // длинна стороны с

WriteLine(IsTriangle(a,b,c)? "Треугольник существует ":"Треугольник не существует ");

//Переменные сторон
bool IsTriangle(int inA, int inB, int inC)
{ // если сумма двух сторон больше третей. Проверяем все три стороны
    return (inA + inB > inC && inA + inC > inB && inB + inC > inA); // если верно возвращаем да
}

int AskUserForNamber(string inPromt)
{
    int resultNum = 0;
    string userInput = "";
    while (!int.TryParse(userInput, out resultNum))
    {
        Console.Write(inPromt);
        userInput = Console.ReadLine()!;
    }
    return resultNum;
}