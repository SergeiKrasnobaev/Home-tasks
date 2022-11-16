// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Укажите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] RandomArray(int num)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 9);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} , ");
        else Console.Write($"{array[i]}");
    }
    Console.Write(" ]");
}
int SumOddIndexArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
int[] r = RandomArray(n);
PrintArray(r);
int s = SumOddIndexArray(r);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечётных позициях: {s} ");