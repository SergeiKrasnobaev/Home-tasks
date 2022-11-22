// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите m элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n элемента: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-10, 10);
        }
    }
    return matrix;
}
int matrixElement(int[,] matrix, int a = 0, int b = 0)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[a, b] == matrix[i, j]) ; //в 28 строке "Возможно, ошибочный пустой оператор" ; - желтая
        }
    }
    return matrix[a, b];
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}   ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("");
    }
}

int[,] createMatrix = CreateMatrix(3, 3, -10, 10);
PrintMatrix(createMatrix);
if (m < createMatrix.GetLength(0) && n < createMatrix.GetLength(1))
{
    int mElement = matrixElement(createMatrix, m, n);
    Console.Write($" элемент на позиции [{m},{n}] : {mElement}");
}
else
{
    Console.Write($"элемент на позиции [{m},{n}] не найден");
}



