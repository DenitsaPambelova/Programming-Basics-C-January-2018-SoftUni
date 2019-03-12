using System;

class Fishland
{
    static void Main(string[] args)
    {
        double skumriaPrice = double.Parse(Console.ReadLine());
        double cacaPrice = double.Parse(Console.ReadLine());
        double palamud = double.Parse(Console.ReadLine());
        double safrid = double.Parse(Console.ReadLine());
        double midi = double.Parse(Console.ReadLine());

        double palamudPrice = skumriaPrice * 1.6;
        double safridPrice = cacaPrice * 1.8;
        double midiPrice = 7.50;
        double moneyNeeded = palamud * palamudPrice + safrid * safridPrice + midi * midiPrice;

        Console.WriteLine($"{moneyNeeded:F2}");
    }
}