// // 1. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находится
// эта точка.

void Qourters(int x, int y)
{
    if (x == 0 || y == 0) Console.WriteLine("x=0, y=0");
    else if (x > 0 & y > 0) Console.WriteLine("1 четверть");
    else if (x < 0 & y > 0) Console.WriteLine("2 четверть");
    else if (x < 0 & y < 0) Console.WriteLine("3 четверть");
    else if (x > 0 & y < 0) Console.WriteLine("4 четверть");
}

Qourters(0, 0);
Qourters(10, 10);
Qourters(-10, -10);
Qourters(10, -10);