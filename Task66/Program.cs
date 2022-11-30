// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void ElementsSum(int m, int n)
{
    if (m > n) return;
    {
        int sum = 0;
        ElementsSum(sum = m + (m + 1), n);

        Console.Write($"{sum}");
    }
}
ElementsSum(M, N);
