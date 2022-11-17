// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заполните массив числами через Enter: ");
int[] FillArray(int num)
{
    int[] array = new int[num];
    // Console.WriteLine("Заполните массив числами через Enter: ");
    for (int i = 0; i < array.Length; i++)
    {
        int digit = Convert.ToInt32(Console.ReadLine());
        array[i] = digit;
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int DigitMoreNullArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}
int[] fillArray = FillArray(n);
Console.WriteLine();
PrintArray(fillArray);
int digitMoreNullArray = DigitMoreNullArray(fillArray);
Console.WriteLine();
Console.WriteLine($"Чисел в массиве > 0 : {digitMoreNullArray}");

