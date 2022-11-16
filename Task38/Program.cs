// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Укажите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] RandomArray(int num)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-50, +50); // вещественные числа от -50 ло +50
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
int DiffMathMaxMinArray(int[] array)
{
    int max = default;
    int min = default;
    int result = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        result = max - min;
    }
    return result;
}
int[] r = RandomArray(n);
PrintArray(r);
int d = DiffMathMaxMinArray(r);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива : {d} ");