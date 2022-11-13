// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число >= 10");
int i = Convert.ToInt32(Console.ReadLine());
if (i != 0 && i >= 10)
{
    int Sum(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int num = n % 10;
            n = n / 10;
            sum = sum + num;
        }
        return sum;
    }
    Console.WriteLine($"Сумма цифр в числе {i} равна: {Sum(i)}");
}
else
{
    Console.WriteLine("Некорректный ввод");
}

