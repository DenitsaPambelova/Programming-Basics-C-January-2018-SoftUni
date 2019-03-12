using System;

class CircleAreaAndPerimeter
{
    static void Main(string[] args)
    {
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;
        double perimeter = Math.PI * radius * 2;

        Console.WriteLine($"Area = {area}");
        Console.WriteLine($"Perimeter = {perimeter}");
    }
}