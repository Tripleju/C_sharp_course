// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Weekend(int num)
{
    if (num == 6 | num == 7)
    {
        Console.WriteLine("-> да");
    }
    else Console.WriteLine("-> нет");
}

int num = int.Parse(Console.ReadLine());
Weekend(num);