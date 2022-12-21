using static System.Console;

WriteLine("Введите первое число a: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите первое число b: ");
int b = Convert.ToInt32(ReadLine());

//if (a*a==b || b*b==a)

WriteLine(a*a==b? "b является квадратом a"
        :b*b==a?  "a является квадратом b"
        :"не являются квадратоми друг друга");