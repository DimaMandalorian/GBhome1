//  6 знаковый билетик, сумма первых трех равна сумме вторых трех
// счастливый или не счастливый 

using static System.Console;
Clear();

// //Вариант со строковым вводом данных
// writeLine("Введите номер билета:");
// string ticket = ReadLine();

//Вариант с целочисленным вводом данных
int ticket = AskUserForNamber("Введите номер билета: ");
WriteLine(IsLuckyTicket(ticket) ? $"Билетик {ticket} Счастливый." : $"Билетик {ticket} не счастливый");


bool IsLuckyTicket(int inNum)
{
    //123456
    //abcdef
    int a = inNum / 100000;
    int b = (inNum / 10000) %10;
    int c = (inNum / 1000) % 10;
    int d = (inNum % 1000) / 100;
    int e = (inNum % 1000) / 10 % 10;
    int f = (inNum % 1000) % 10;
    //Для проверки вычислений
    WriteLine($"{a} {b} {c} {d} {e} {f}");
    return (a+b+c == d+e+f);
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