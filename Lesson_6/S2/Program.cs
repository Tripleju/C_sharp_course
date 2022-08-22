// 2. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void Binary(int num)
{
    string Dec ="";
    while (num>0)
    {
        Dec=num%2+Dec;
        num/=2;
    }
    Console.WriteLine(Dec);
}
Binary(2);
Binary(3);
Binary(45);