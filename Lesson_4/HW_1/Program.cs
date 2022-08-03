// Задача 1: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Degree(double A, int B)
{
    double result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}
Console.WriteLine(Degree(2, 4));
Console.WriteLine(Degree(3, 5));