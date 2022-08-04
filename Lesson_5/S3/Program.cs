// 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.


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
arr[i] = new Random().Next(-9, 10);
}
return arr;
}

void CheckNum(int[] arr, int num)
{
    string flag="No";
    for (int i = 0; i < arr.Length; i++)
    {
       if(num==arr[i]) 
       {
       flag="yes";
        break;
       }
      
    
    }
     Console.WriteLine($"{num},->{flag}");
}
int[] arr_1 =MassNum(12);
Print(arr_1);
CheckNum(arr_1,5);
