// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

using static System.Console;
//Clear();
Write("Введите число: "); 
int n = int.Parse(ReadLine()!);
int number = n;
int n2 = 0;

while(n>0)
{n2=(n2*10)+(n%10);n=n/10;}
WriteLine($"{n2}");

WriteLine(number==n2? " ДА ":" Нет ");
// if (number==n2)
// {
//     WriteLine($" {n2} да, палиндром");
// }
// else
// {
//     WriteLine($" {n2} не палиндром");
// }

//второй вариант не смог сообразить как к переменной  n2 приравнять
// using static System.Console; 
 
// Write("Введите число: "); 
// int n = int.Parse(ReadLine()!);
// int n2=0;

//     Write(n % 10);
//     while(!((n=n / 10) == 0))
//     Write((n % 10));

// WriteLine(n2==n? " Нет ":" Да ");