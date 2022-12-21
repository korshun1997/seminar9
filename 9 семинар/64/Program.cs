// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
void ShowNumbers(int N)
{
    if (N > 0) Console.WriteLine(N + " ");
    ShowNumbers(N - 1);
        
    
}
Console.WriteLine();
ShowNumbers(N);