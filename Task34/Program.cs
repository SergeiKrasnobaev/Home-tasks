// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Укажите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int num)
{
    int[] array = new int[num];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999); //трёхзначные числа
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} , ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int EvenNumArray(int[] array)
{
    int evenCount = 0; // счётчик чётных чисел
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenCount = evenCount + 1;
        }
    }
    return evenCount;
}

int[] r = RandomArray(n);
PrintArray(r);
int e = EvenNumArray(r);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел: {e} ");










