// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
arr[i] = new Random().Next(100, 1000);
}
return arr;
}

void CountEvenNum(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
       if(arr[i]%2 == 0) 
       {
       count+=1;

       }
      
    }
     Console.WriteLine($"Count Even={count}");
}
int[] arr_1 =MassNum(12);
Print(arr_1);
CountEvenNum(arr_1);
