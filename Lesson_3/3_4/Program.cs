﻿// Задача 3: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void SQRT(int num)
{
    int count=1;
    while(count<=num)
    {
        Console.Write($"{Math.Pow(count,2)}, ");
        count++;
    }
}

SQRT(5);
SQRT(2);