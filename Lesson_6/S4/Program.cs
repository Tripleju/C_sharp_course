// Задача 4: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. (двумерный массив взять)

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
      Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNum(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i,j] = new Random().Next(from, to);
        }
    
    }
    return arr;
}

int[,] CopyMass(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    int[,] new_arr = new int[row_size,column_size];

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
             new_arr[i,j]=arr[i,j];
        }
       
    }
    return new_arr;
}
int[,] arr_1=MassNum(2,5,1,30);
Print(arr_1);
int[,] arr_2=CopyMass(arr_1);
Print(arr_2);

