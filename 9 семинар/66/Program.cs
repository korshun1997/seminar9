// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void ShowNumbers(int N, int M)
{
    if (Math.Max(M,N) != Math.Min(M,N)) 
    ShowNumbers(Math.Max(M,N) - 1, Math.Min(M,N));
    
    Console.WriteLine($"{Math.Max(M,N)} ");    
    
}
Console.WriteLine();
ShowNumbers(N, M);
for (int i =  Math.Min(M,N); i <= Math.Max(M,N); i++)    
    {
      sum = sum + i;  
    }
    Console.WriteLine($"{sum}");