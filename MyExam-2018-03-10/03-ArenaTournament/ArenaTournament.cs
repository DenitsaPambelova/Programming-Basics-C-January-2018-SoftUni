using System;

class ArenaTournament
{
    static void Main(string[] args)
    {
        double points = double.Parse(Console.ReadLine());
        string arena = Console.ReadLine();
        string day = Console.ReadLine();
        string condition = Console.ReadLine();
        double price = 0;
        int count = 0;

        switch (condition)
        {
            case "Poor":
                price = 7000 / 5;
                break;
            case "Normal":
                price = 14000 / 5;
                break;
            case "Legendary":
                price = 21000 / 5;
                break;
        }

        switch (arena)
        {
            case "Nagrand":
                if (day == "Monday" || day == "Wednesday")
                {
                    price *= 0.95;
                }
                break;
            case "Gurubashi":
                if (day == "Tuesday" || day == "Thursday")
                {
                    price *= 0.9;
                }
                break;
            case "Dire Maul":
                if (day == "Friday" || day == "Saturday")
                {
                    price *= 0.93;
                }
                break;
        }

        while (points >= price && count < 5)
        {
            points -= price;
            count++;
        }

        Console.WriteLine($"Items bought: {count}");
        Console.WriteLine($"Arena points left: {points}");

        if (count == 5)
        {
            Console.WriteLine("Success!");
        }
        else
        {
            Console.WriteLine("Failure!");
        }
    }
}