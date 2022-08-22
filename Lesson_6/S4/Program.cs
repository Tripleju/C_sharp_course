// Задача 4: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. (двумерный массив взять)

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNum(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int CopyMass(int size)
{
    int[] arr2 = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr2[i]=arr[i];
    }
    return arr2;
}
int arr_1=MassNum(5,1,30);
Print(arr_1);
int arr_2=CopyMass(arr_1);
Print(arr_2);

