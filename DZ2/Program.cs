/*Задача 10
Console.Write("Введите трёхзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

if ((num>-99 && num<99 )||(num<-999||num>999))
{
    Console.Write("Введено неверное число");
}
else
{
    int result = (num/10)%10;
    Console.Write($"Вторая цифра числа: {Math.Abs(result)}");
}
*/
/*Задача 13
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int x=10;
int count=1;

if (num<100 && num>-100)
{
    Console.Write("Третьей цифры нет");
}
else
{
    while(num/x>99 || num/x<-99 )
    {
        x=x*10;
        count=count+1;
    }
    long result=(num%x)/count;
    Console.Write($"Третья цифра: {Math.Abs(result)}");
}
*/
System.Console.WriteLine("Введите цифру от 1 до 7:");
int x = Convert.ToInt32(Console.ReadLine());

switch(x)
{
    case 1:
     System.Console.WriteLine("Понедельник,не выходной");
     break;
    case 2:
     System.Console.WriteLine("Вторник,не выходной");
     break;
    case 3:
     System.Console.WriteLine("Среда,не выходной");
     break;
    case 4:
     System.Console.WriteLine("Четверг,не выходной");
     break;
    case 5:
     System.Console.WriteLine("Пятница,не выходной");
     break;
    case 6:
     System.Console.WriteLine("Суббота,выходной");
     break;
    case 7:
     System.Console.WriteLine("Воскресенье,выходной");
     break;
    default:
     System.Console.WriteLine("Это не день недели");
     break;     
}


    

