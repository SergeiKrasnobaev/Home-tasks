// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] CrossPoint(double bb1, double kk1, double bb2, double kk2) 
{
    double[] array = new double[2];
    double x = (bb2 - bb1) / (kk1 - kk2);
    double y = kk1 * x + bb1;
    for (int i = 0; i < 2; i++)
    {
        array[i] = x;
        array[i] = y;
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("Координаты точки пересечения двух прямых ");
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ; ");
        else Console.Write($"{array[i]}");
    }
    Console.Write(")");
}

double[] crossPoint = CrossPoint(b1, k1, b2, k2);
PrintArray(crossPoint);







