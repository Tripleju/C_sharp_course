// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
//  и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void DiffMaxMin(int[] arr)
{
    int diff = 0;
    int max=0;
    int min=100;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max)
        {
            max=arr[i];
        }
    }
     for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<min)
        {
            min=arr[i];
        }
    }   
    diff=max-min;
    Console.WriteLine($"Max Number - Min Number={diff}");
}
int[] arr_1 = MassNum(7);
Print(arr_1);
DiffMaxMin(arr_1);