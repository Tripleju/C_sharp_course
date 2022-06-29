// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());


if (num2 > num1)
// Console.WriteLine(num2);
{
    Console.WriteLine($"{num2}>{num1}, max={num2}");
}
else
{
    Console.WriteLine($"{num1}>{num2}, max={num1}");

}