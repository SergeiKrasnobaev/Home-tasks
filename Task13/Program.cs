﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет. 

Console.WriteLine("Введите целое число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 100)
{
    while (n > 999)
    {
        {
            n = n / 10;
        }
    }

    Console.WriteLine($"Третья цифра в этом числе: {n % 10}");
}
else Console.WriteLine($"Третьей цифры в этом числе нет");
