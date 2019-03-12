using System;

class MatchTickets
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine().ToLower();
        int people = int.Parse(Console.ReadLine());

        double money = budget * 0.75;
        double price = 249.99;

        if (people <= 4)
        {
            money = budget * 0.25;
        }
        else if (people <= 9)
        {
            money = budget * 0.40;
        }
        else if (people <= 24)
        {
            money = budget * 0.50;
        }
        else if (people <= 49)
        {
            money = budget * 0.60;
        }

        if (category == "vip")
        {
            price = 499.99;
        }

        double ticketsCost = price * people;

        if (money > ticketsCost)
        {
            Console.WriteLine($"Yes! You have {money - ticketsCost:F2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {ticketsCost - money:F2} leva.");
        }
    }
}