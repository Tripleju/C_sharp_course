// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

// static int CheckinValues(in int val1, in int val2)
//         {
//             return (val1 % val2);
//         }
        
//         static void Main(string[] args)
//         {
//             Console.Write("Введите первое число ");
//             int value1 = int.Parse(Console.ReadLine());
//             Console.Write("Введите второе число ");
//             int value2 = int.Parse(Console.ReadLine());

//             int val = CheckinValues(in value1, in value2);

//             if (val == 0)
//             {
//                 Console.WriteLine("Числа кратные");
//             }
//             else
//             {
//                 Console.WriteLine($"Остаток от деления {val}");
//             }
//         }

void OneOfNum(int num_1, int num_2)
{       
    if (num_1 % num_2 == 0)
    {
        Console.WriteLine($"{num_1}, {num_2} -> multiple");
    }
    else
    {
        Console.WriteLine($"{num_1}, {num_2} -> not multiple, the remainder {num_1 % num_2}");        
    }    
}

OneOfNum(16, 4);
OneOfNum(22, 4);
