// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNum(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-20, 100);
    }
    return arr;
}
// мой вариант
void SummOddPositionNum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += arr[i];
        }

    }
    Console.WriteLine($"Sum Odd Position Number={sum}");
}

// вариант преподавателя c int
void SummOddPositionNum_check(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    Console.WriteLine($"Sum Odd Position Number 2={sum}");
}

int[] arr_1 = MassNum(5);
Print(arr_1);
SummOddPositionNum(arr_1);
SummOddPositionNum_check(arr_1);


