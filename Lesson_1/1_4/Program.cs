
int N = int.Parse(Console.ReadLine());
int M = -N;
while (N > M - 1)
{
    Console.WriteLine(-N);
    N = N - 1;
}

