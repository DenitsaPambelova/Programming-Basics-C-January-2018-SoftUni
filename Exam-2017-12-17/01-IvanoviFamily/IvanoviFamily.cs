using System;

class IvanoviFamily
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());
        double secondPrice = double.Parse(Console.ReadLine());
        double thirdPrice = double.Parse(Console.ReadLine());

        double fullPrice = firstPrice + secondPrice + thirdPrice;
        double charity = (budget - fullPrice) * 0.9;

        Console.WriteLine($"{charity:F2}");
    }
}