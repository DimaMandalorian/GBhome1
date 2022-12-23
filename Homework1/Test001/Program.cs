using static System.Console; 
 
Write("Введите число: "); 
int a = int.Parse(ReadLine()!); 
 
if(a<99) 
{ 
    WriteLine("третьей цифры нет"); 
} 
else if(a>999) 
{ 
    WriteLine((a/100)%10); 
}
else 
{ 
    WriteLine(a%10); 
}