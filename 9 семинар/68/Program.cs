// Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int M = 0;
int k = 0;
void Binary(int N, int M)
{
    if (N>=1) 
    do
    {
    M = N % 2;
    N = N / 2;
    Console.Write($"{M}");
    k++;    
    }
    while (N>=1);
}
Binary(N, M);