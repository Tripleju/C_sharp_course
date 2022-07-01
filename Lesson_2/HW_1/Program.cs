// Задача 1: Напишите программу, которая принимает навход трёхзначное число 
// и на выходе показывает вторуюцифру этого числа.

int SecondNum(int num)
{
    return (num / 10) % 10;
}

int num = int.Parse(Console.ReadLine());
Console.WriteLine(SecondNum(num));
