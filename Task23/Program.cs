// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.


Console.WriteLine("Таблица кубов от 1 до N");
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void CubeTable(int n)
{
    if (n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i}  {i*i*i}");
        }
    }
    else
    {
        Console.WriteLine("Введите число больше 0");
    }
}

CubeTable(N);