// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] CreateMatrix(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * rnd.Next(-10, 10);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],20}   ");
            else Console.Write($"{matrix[i, j],20} ");
        }
        Console.WriteLine("");
    }

}

double[,] createMatrix = CreateMatrix(3, 3, -10, 10);
PrintMatrix(createMatrix);


// double[,] CreateMatrixRndInt(double rows, double columns, double min, double max)
// {
//     double[,] matrix = new double[rows, columns];
//     Random rnd = new Random();

//     for (double j = 0; j < matrix.GetLength(1); j++) // 2
//     {
//         for (double i = 0; i < matrix.GetLength(0); i++) //
//         {
//             matrix[i, j] = rnd.Next(min, max + 1); // 2 - 3
//         }

//     }
//     return matrix;
// }
// void PrintMatrix(double[,] matrix)
// {
//     for (double i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("");
//         for (double j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]},");
//             else Console.Write($"{matrix[i, j]}");
//         }
//         Console.WriteLine("");
//     }
// }

// double[,] array2D = CreateMatrixRndInt(3, 5, 0, 50);
// PrintMatrix(array2D);