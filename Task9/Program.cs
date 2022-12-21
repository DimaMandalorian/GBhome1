using static System.Console;
Clear();
int namber=new Random().Next(10,100);
WriteLine(namber);
WriteLine(namber%2==0?"Even":"add");
WriteLine(namber/10>namber%10?namber/10:namber%10);

//if(a1>a2);
//{
//   WriteLine(a1);
//}
//else
//{
//   WriteLine(a2);
//}