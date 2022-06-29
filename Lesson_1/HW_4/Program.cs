// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int N = int.Parse(Console.ReadLine());
int M = 2;
while (M <= N)
{
    Console.WriteLine(M);
    M += 2;
}
