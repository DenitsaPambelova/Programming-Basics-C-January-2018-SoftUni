using System;

class Vacation
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();

        string location = "";
        string type = "Hotel";
        double price = budget * 0.9;

        if (season == "summer")
        {
            location = "Alaska";
        }
        else
        {
            location = "Morocco";
        }

        if (budget <= 1000)
        {
            type = "Camp";

            if (season == "summer")
            {
                price = budget * 0.65;
            }
            else
            {
                price = budget * 0.45;
            }
        }
        else if (budget <= 3000)
        {
            type = "Hut";

            if (season == "summer")
            {
                price = budget * 0.8;
            }
            else
            {
                price = budget * 0.6;
            }
        }

        Console.WriteLine($"{location} - {type} - {price:F2}");
    }
}