using static System.Console;
Clear();

Write("Введите количество деталей за смену: ");
int quantity=int.Parse(ReadLine()!);
int result=quantity%6;

if (result==0)
WriteLine($"Младшие токари сделали по {quantity/6} детадей, Старший {quantity/6*4} деталей");

else    WriteLine("старший токарь ошибся");
