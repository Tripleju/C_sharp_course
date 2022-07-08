// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные элементы

int[] arr={5,3,7,2,4,6,9,8,3,2,8,4};

void PrintArray(int[] array)
{
    int count=array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int MinPosition=i;



        int temporary=array[i];
        array[i]=array[MinPosition];
        array[MinPosition]=temporary;




    }
}


PrintArray(arr);