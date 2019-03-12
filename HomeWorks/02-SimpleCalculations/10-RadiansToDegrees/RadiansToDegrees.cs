using System;

class RadiansToDegrees
{
    static void Main(string[] args)
    {
        double radians = double.Parse(Console.ReadLine());

        double degrees = (180 / Math.PI) * radians;

        Console.WriteLine($"{degrees:F2}");
    }
}