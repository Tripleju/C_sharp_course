// Задача 1: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Count(int num)
{
    string result=num.ToString();
    return result.Length;
}
Console.WriteLine(Count(456));
Console.WriteLine(Count(78));
Console.WriteLine(Count(89126));