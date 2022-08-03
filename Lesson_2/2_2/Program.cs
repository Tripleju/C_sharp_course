// 2. Напишите программу, которая выводит случайное число
//    из отрезка [10, 99] и показывает наибольшую цифру числа.

int MaxNum(int num)
{
    if(num % 10>num/10)
    {
        return num % 10;
    }
    else
        return num/10;
}

// Console.WriteLine(TakeNum(678));
// Console.WriteLine(TakeNum(678565565));

int secondnum=new Random().Next(10,100);
MaxNum(secondnum);
Console.WriteLine(secondnum);
Console.WriteLine(MaxNum(secondnum));