// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A : ");
int digitA = Convert.ToInt32(Console.ReadLine());
if (digitA != 0)
{
    Console.WriteLine("Введите число B : ");
    int digitB = Convert.ToInt32(Console.ReadLine());
    if (digitB > 0 && digitB % 1 == 0)
    {
        int stepen = Stepen(digitA, digitB);
        Console.WriteLine($"Ответ: A в степени В -> {stepen}");
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Число B натуральное.");
    }
}
else
{
    Console.WriteLine("Некорректный ввод. Число A не равно 0");
}

int Stepen(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}






