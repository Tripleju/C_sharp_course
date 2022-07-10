// Задача 2: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumSum(int num)
{
    string numLength = num.ToString();
    int count = numLength.Length;
    int result = 0;
    int body = num;
    for (int i = 1; i <= count; i++)
    {
        int remain = body % 10;
        body = body / 10;
        result = result + remain;
    }
    return result;
}

Console.WriteLine(NumSum(452));
Console.WriteLine(NumSum(82));
Console.WriteLine(NumSum(9012));