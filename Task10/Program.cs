// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите целое трёхзначное число:");

int nnn = Convert.ToInt32(Console.ReadLine());
if (nnn > 99 && nnn < 1000)
{
    int secondDigit = (nnn / 10) % 10;

    Console.WriteLine($"Вторая цифра этого числа: {secondDigit}");
}
else
    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
