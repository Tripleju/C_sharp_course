// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



void CountPositiveNum(int size)
{
int[] arr = new int[size];
int count=0;
// Console.WriteLine("Введите число");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите следующее число");
        arr[i] = int.Parse(Console.ReadLine());
        if(arr[i]>0) count++;
    }
Console.WriteLine($"Количество положительных чисел={count}");
}

CountPositiveNum(6);