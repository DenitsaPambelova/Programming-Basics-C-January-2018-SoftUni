using System;

class Travel
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();

        string destination = "Europe";
        string type = "Hotel";
        double spent = budget * 0.9;

        if (budget <= 100 && season == "summer")
        {
            destination = "Bulgaria";
            type = "Camp";
            spent = budget * 0.3;
        }
        else if (budget <= 100 && season == "winter")
        {
            destination = "Bulgaria";
            type = "Hotel";
            spent = budget * 0.7;
        }
        else if (budget <= 1000 && season == "summer")
        {
            destination = "Balkans";
            type = "Camp";
            spent = budget * 0.4;
        }
        else if (budget <= 1000 && season == "winter")
        {
            destination = "Balkans";
            type = "Hotel";
            spent = budget * 0.8;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{type} - {spent:F2}");
    }
}