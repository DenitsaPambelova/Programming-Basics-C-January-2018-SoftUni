using System;

class TransportPrice
{
    static void Main(string[] args)
    {
        int amount = int.Parse(Console.ReadLine());
        string dayTime = Console.ReadLine();

        double cheapestPrice = 0;

        if (amount < 20)
        {
            if (dayTime == "day")
            {
                cheapestPrice = amount * 0.79 + 0.70;
            }
            else
            {
                cheapestPrice = amount * 0.90 + 0.70;
            }
        }
        else if (amount < 100)
        {
            cheapestPrice = amount * 0.09;
        }
        else
        {
            cheapestPrice = amount * 0.06;
        }
        Console.WriteLine($"{cheapestPrice:F2}");
    }
}