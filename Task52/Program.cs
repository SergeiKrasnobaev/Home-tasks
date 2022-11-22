// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] createMatrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < createMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < createMatrix.GetLength(1); j++)
        {
            createMatrix[i, j] = rnd.Next() * rnd.Next(-10, 10);
        }
    }
    return createMatrix;
}

int[] SumElementsColumns(int[,] createMatrix)
{
    int[] sumElements = new int[5];
    int sum = 0;
    for (int j = 0; j < createMatrix.GetLength(1); j++)
    {
        for (int i = 0; i < createMatrix.GetLength(0); i++)
        {
            sum = sum + createMatrix[i, j];
            sumElements[5] = sum;
        }
    }
    return sumElements;
}

void PrintSumElements(int[] sumElements)
{
    Console.Write("[");
    for (int i = 0; i < sumElements.Length; i++)
    {
        if (i < sumElements.Length - 1) Console.Write($"{sumElements[i]} , ");
        else Console.Write($"{sumElements[i]}");
    }
    Console.Write("]");
}

int [,] createMatrix = CreateMatrix (3, 3, -10, 10);
int [] SumElementsColumns()
