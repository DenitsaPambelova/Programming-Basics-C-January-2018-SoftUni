using System;

class Pets
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        int foodLeft = int.Parse(Console.ReadLine());
        double dog = double.Parse(Console.ReadLine());
        double cat = double.Parse(Console.ReadLine());
        double turtle = double.Parse(Console.ReadLine());

        double foodNeeded = days * (dog + cat + turtle / 1000);
        string output = $"{Math.Ceiling(foodNeeded - foodLeft)} more kilos of food are needed.";

        if (foodLeft >= foodNeeded)
        {
            output = $"{Math.Floor(foodLeft - foodNeeded)} kilos of food left.";
        }

        Console.WriteLine(output);
    }
}