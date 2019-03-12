using System;

class AlchoholMarket
{
    static void Main(string[] args)
    {
        double whiskyPrice = double.Parse(Console.ReadLine());
        double beerLitters = double.Parse(Console.ReadLine());
        double wineLitters = double.Parse(Console.ReadLine());
        double rakiaLitters = double.Parse(Console.ReadLine());
        double whiskyLitters = double.Parse(Console.ReadLine());

        double rakiaPrice = whiskyPrice / 2;
        double winePrice = 0.6 * rakiaPrice;
        double beerPrice = 0.2 * rakiaPrice;
        double moneyNeeded = beerLitters * beerPrice + wineLitters * winePrice + rakiaLitters * rakiaPrice + whiskyLitters * whiskyPrice;

        Console.WriteLine($"{moneyNeeded:F2}");
    }
}