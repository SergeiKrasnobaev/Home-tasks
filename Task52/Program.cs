// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] createMatrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < createMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < createMatrix.GetLength(1); j++)
        {
            createMatrix[i, j] = rnd.Next(-10, 10);
        }
    }
    return createMatrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}   ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("");
    }
}
double[] MiddleMathElementsColumns(int[,] createMatrix)
{
    int count = 0;
    double[] middleMathElementsColumn = new double[createMatrix.GetLength(1)];
    for (int j = 0; j < createMatrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < createMatrix.GetLength(0); i++)
        {
            sum = sum + createMatrix[i, j];
        }
        middleMathElementsColumn[count] = Math.Round(sum / createMatrix.GetLength(0), 2);
        count++;
    }
    return middleMathElementsColumn;
}

void PrintArray(double[] array)
{
    Console.Write("");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}| ");
        else Console.Write($"{array[i]}  ");
    }
    Console.Write("");
}

int[,] createMatrix = CreateMatrix(3, 3, -10, 10);
PrintMatrix(createMatrix);
double[] middleSumColumnsArray = MiddleMathElementsColumns(createMatrix);
Console.Write($"Среднее арифметическое значение элементов каждого столбца: ");
PrintArray(middleSumColumnsArray);

