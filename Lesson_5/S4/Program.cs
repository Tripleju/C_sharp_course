// 3. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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
arr[i] = new Random().Next(0, 500);
}
return arr;
}

void CountNum(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
       if(arr[i]>=10 && arr[i]<=99) 
       {
       count+=1;

       }
      
    
    }
     Console.WriteLine($"Count={count}");
}
int[] arr_1 =MassNum(123);
Print(arr_1);
CountNum(arr_1);
