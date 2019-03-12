using System;

class BikeRace
{
    static void Main(string[] args)
    {
        int juniors = int.Parse(Console.ReadLine());
        int seniors = int.Parse(Console.ReadLine());
        string trace = Console.ReadLine().ToLower();

        double money = 0;

        switch (trace)
        {
            case "trail":
                money = juniors * 5.5 + seniors * 7;
                break;
            case "cross-country":
                money = juniors * 8 + seniors * 9.5;

                if (juniors + seniors >= 50)
                {
                    money *= 0.75;
                }

                break;
            case "downhill":
                money = juniors * 12.25 + seniors * 13.75;
                break;
            case "road":
                money = juniors * 20 + seniors * 21.50;
                break;
        }

        money *= 0.95;

        Console.WriteLine($"{money:F2}");
    }
}