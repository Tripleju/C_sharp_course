﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).

int num = int.Parse(Console.ReadLine());

if (num%2==0)

{
    Console.WriteLine($"Остаток от деления на 2= {num%2}, {num}-четное");
}
else
{
    Console.WriteLine($"Остаток от деления на 2= {num%2}, {num}-нечетное");
}