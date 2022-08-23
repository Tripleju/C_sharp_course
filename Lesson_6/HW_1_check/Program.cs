// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

//вариант 1

// int Check(int num)
// {
//     int count = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         Console.WriteLine($"Введите число {i}");
//         int a = int.Parse(Console.ReadLine());
//         if (a > 0) count++;
//     }
//     return count;
// }
// Console.Write("Сколько чисел вы хотите ввести?");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine($"Количество положительных чисел={Check(b)}");

// вариант 2
int CountNum()
{
    int count=0;
    string word;

    while(true)
    {
        Console.Write("Введите любое число: ");
        word=Console.ReadLine();

        if(word=="") return count;
        else if (int.Parse(word)>0) count++;
    }
}
Console.WriteLine($"Количество положительных чисел={CountNum()}");