using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());

        Console.WriteLine(sideA * sideB);
    }
}