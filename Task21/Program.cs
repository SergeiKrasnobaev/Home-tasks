// Задача 21:
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние (AB) между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты точки А: ");
Console.Write("x : ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("y : ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("z : ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("x : ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("y : ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("z : ");
double zB = Convert.ToDouble(Console.ReadLine());

double DistanceAB(double n1, double n2, double n3, double n4, double n5, double n6)
{
    double d1 = n1 - n2;
    double d2 = n3 - n4;
    double d3 = n5 - n6;
    double D = Math.Sqrt(d1 * d1 + d2 * d2 + d3 * d3);
    double res = Math.Round(D, 2, MidpointRounding.ToZero);
    return res;
}
double result = DistanceAB(xA, xB, yA, yB, zA, zB);
Console.WriteLine($"АВ = {result}");
