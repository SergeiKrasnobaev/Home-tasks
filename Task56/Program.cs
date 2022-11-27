// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1}   ");
            else Console.Write($"{matrix[i, j],1} ");
        }
        Console.WriteLine("");
    }
}

int[] SumInRowsArray(int[,] matrix)
{
    int count = 0;

    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        int sum = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        array[count] = sum;
        count++;
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

int FindIndexMinElement(int[] array)
{
    int k = default;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            k = i;
        }
    }
    return k + 1;
}

int[,] createMatrix = CreateMatrix(5, 3, 1, 10);
PrintMatrix(createMatrix);
Console.WriteLine("");
int[] array2 = SumInRowsArray(createMatrix);
PrintArray(array2);
int num = FindIndexMinElement(array2);
Console.WriteLine("");
Console.Write($"Номер строки с наименьшей суммой элементов: {num}");

