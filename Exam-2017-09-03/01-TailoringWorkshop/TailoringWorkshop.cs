using System;

class TailoringWorkshop
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());

        double coversArea = count * (sideA + 2 * 0.30) * (sideB + 2 * 0.30);
        double squaresArea = count * (sideA / 2) * (sideA / 2);
        double priceUSD = coversArea * 7 + squaresArea * 9;
        double priceBGN = priceUSD * 1.85;

        Console.WriteLine($"{priceUSD:F2} USD");
        Console.WriteLine($"{priceBGN:F2} BGN");
    }
}