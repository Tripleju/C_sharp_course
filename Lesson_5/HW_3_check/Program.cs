// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
//  и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// разбор преподавателя

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNum(int size)
{
    double[] arr = new double[size];
    Random n_new=new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble()*(10+22)-10,2);
    }
    return arr;
}

void DiffMaxMin(double[] arr)
{
    // int diff = 0;
    double max=arr[0];
    double min=arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max)
        {
            max=arr[i];
        }
  
        else if (arr[i]<min)
        {
            min=arr[i];
        }
    }   
    // diff=max-min;
    Console.Write($"Max Number: {max}, Min Number: {min}");

    Console.WriteLine($"Max Number - Min Number={Math.Round(max-min,2)}");
}
double[] arr_1 = MassNum(7);
Print(arr_1);
DiffMaxMin(arr_1);
