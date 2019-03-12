using System;

class ChangeTiles
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double lenght = double.Parse(Console.ReadLine());
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double tilePrice = double.Parse(Console.ReadLine());
        double work = double.Parse(Console.ReadLine());

        double area = width * lenght;
        double tileArea = side * height / 2;
        double tiles = Math.Ceiling(area / tileArea) + 5;
        double finalPrice = tiles * tilePrice + work;
        string output = $"You'll need {finalPrice - budget:F2} lv more.";

        if (budget >= finalPrice)
        {
            output = $"{budget - finalPrice:F2} lv left.";
        }

        Console.WriteLine(output);
    }
}