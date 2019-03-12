using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double sideA = Math.Abs(x1 - x2);
        double sideB = Math.Abs(y1 - y2);

        Console.WriteLine(sideA * sideB);
        Console.WriteLine(2 * sideA + 2 * sideB);
    }
}