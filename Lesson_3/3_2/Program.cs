// Задача 1: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

void Qourters(int num)
{
    if (num == 1) Console.WriteLine("x > 0 , y > 0");
    else if (num == 2) Console.WriteLine("x < 0 , y > 0");
    else if (num == 3) Console.WriteLine("x < 0 , y < 0");
    else if (num == 4) Console.WriteLine("x > 0 , y < 0");
    else Console.WriteLine("не верно");
}

Qourters(1);
Qourters(2);
Qourters(3);
Qourters(4);