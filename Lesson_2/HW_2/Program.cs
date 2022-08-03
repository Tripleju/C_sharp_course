// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void ThirdNum(int num)
{
    while(num>=1000)
    {
        num=num/10;
    
    }
    
    if(num<100)
    {
        Console.WriteLine("-> третьей цифры нет");
    }
    else
    {
        Console.WriteLine($"->{num%10}");
    }
}

int num = int.Parse(Console.ReadLine());
ThirdNum(num);