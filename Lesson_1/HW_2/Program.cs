//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    if(num1>num3)
    {
        Console.WriteLine($"max={num1}");
    }
    else
    {
        Console.WriteLine($"max={num3}");
    }
}
else if(num2>num3)
{
    Console.WriteLine($"max={num2}");
}
else
{
    Console.WriteLine($"max={num3}");
}