using System;

class Flowers
{
    static void Main(string[] args)
    {
        int chrysanthemums = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int tulips = int.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();
        bool holiday = char.Parse(Console.ReadLine()) == 'Y';

        double totalPrice = 0;
        double discount = 1;

        if (season == "spring" && tulips > 7)
        {
            discount *= 0.95;
        }

        if (season == "winter" && roses >= 10)
        {
            discount *= 0.9;
        }

        if (chrysanthemums + roses + tulips > 20)
        {
            discount *= 0.8;
        }

        switch (season)
        {
            case "spring":
            case "summer":
                totalPrice = chrysanthemums * 2 + roses * 4.10 + tulips * 2.5;
                break;
            case "autumn":
            case "winter":
                totalPrice = chrysanthemums * 3.75 + roses * 4.50 + tulips * 4.15;
                break;
        }

        if (holiday)
        {
            totalPrice *= 1.15;
        }

        totalPrice *= discount;
        Console.WriteLine($"{totalPrice + 2:F2}");
    }
}
