// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Решение:
// y = k1 * x + b1
// y = k2 * x + b2

// y-y = (k1 * x + b1) - (k2 * x + b2)
// y = k2 * x + b2

// (k1 * x + b1) - (k2 * x + b2) = 0
// (5x + 2) - (9x + 4) = 0
// -4x - 2 = 0
// -4x = 2
// x = -0,5

// x = -0,5
// y = k2 * x + b2

// y = 9 * -0.5 + 4 = -4.5+4 = -0.5




System.Console.WriteLine("Заполните систему уравнений:");
System.Console.WriteLine("y = k1 * x + b1");
System.Console.WriteLine("y = k2 * x + b2");


System.Console.Write($"Enter b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"Enter b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"Enter k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"Enter k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double FindX(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    x = Math.Round(x, 1);
    return x;
}

double FindY()
{
    double y = FindX(b1, b2, k1, k2) * k2 + b2;
    y = Math.Round(y, 1);
    return y;
}

System.Console.WriteLine($"({FindX(b1, b2, k1, k2)}, {FindY()})");