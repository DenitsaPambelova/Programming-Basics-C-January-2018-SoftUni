using System;

class PointInRecrangleBorder
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        string output = "Inside / Outside";

        if (((x == x1 || x == x2) && y >= y1 && y <= y2) || (x >= x1 && x <= x2 && (y == y1 || y == y2)))
        {
            output = "Border";
        }

        Console.WriteLine(output);
    }
}