// 4. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

void Num(int num)
{       
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");        
    }    
}

Num(161);
