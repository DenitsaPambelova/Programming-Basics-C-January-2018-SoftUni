using System;

class Harvest
{
    static void Main(string[] args)
    {
        int area = int.Parse(Console.ReadLine());
        double grapesPerMeter = double.Parse(Console.ReadLine());
        int wineNeeded = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double wineProduced = (area * 0.4 * grapesPerMeter) / 2.5;

        if (wineNeeded > wineProduced)
        {
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded - wineProduced)} liters wine needed.");
        }
        else
        {
            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
            Console.WriteLine($"{Math.Ceiling(wineProduced - wineNeeded)} liters left -> {Math.Ceiling((wineProduced - wineNeeded) / workers)} liters per person.");
        }
    }
}