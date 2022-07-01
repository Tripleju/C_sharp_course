//Задача 2: Напишите программу, которая выводитслучайное трёхзначное число и удаляет вторую цифру
// этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

void SecondDelete(int num)
{
    Console.WriteLine($"{num / 100}" + $"{num % 10}");
}

int num = new Random().Next(100, 1000);

Console.WriteLine(num);
SecondDelete(num);

