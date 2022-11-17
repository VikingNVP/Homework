// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите значение точки B1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки K1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки B2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение точки K2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
float result = FindIntersectionStraightLines(b1, k1, b2, k2);
float result1 = FindIntersectionStraightLine(b2, k2, result);
Console.WriteLine("Пересечение прямых в точке : " + $"({result} ; {result1})");

float FindIntersectionStraightLines(int b1, int k1, int b2, int k2)
{
    float x, a, c;
    a = b2 - b1;
    c = k1 - k2;
    x = a / c;
    return x;
}

float FindIntersectionStraightLine(int b2, int k2, float x)
{
    float y;
    y = k2 * x + b2;
    return y;
}
