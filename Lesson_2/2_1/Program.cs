// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает последнюю цифру этого числа.
int TakeNum(int num)
{
    return num % 10;
}
int num = int.Parse(Console.ReadLine());
Console.WriteLine(TakeNum(num));

