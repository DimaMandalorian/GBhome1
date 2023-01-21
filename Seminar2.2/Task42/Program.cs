// написать программу которая преобразовывает десятичное число
// в двоичное 45 ->  101101   3 -> 11  2 -> 10


using static System.Console;
Clear();

int num = AskUserForNamber("Введите число для перевода в двоичную систему: ");
WriteLine($"Десятичное число {num} перевели в двоичное {decimalToBinary(num)} ");


string decimalToBinary(int inNum)// число передаем в этот метод
{
    if (inNum == 0) return "0";// проверяем число ноль ли это если да выводим 0
    string result = string.Empty;
    // остаток - remainder -> var rem
    int rem; // дополнительная промежуточная переменная

    while (inNum > 0) // цикл разбора числа 
    {
        rem = inNum % 2;
        inNum /= 2;
        result = rem.ToString() + result;
    }
    return result;
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