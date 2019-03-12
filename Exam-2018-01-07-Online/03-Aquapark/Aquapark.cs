using System;

class Aquapark
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        int hours = int.Parse(Console.ReadLine());
        int people = int.Parse(Console.ReadLine());
        string dayTime = Console.ReadLine();

        double price = 0;
        bool working = false;

        if (dayTime == "day")
        {
            switch (month)
            {
                case "march":
                    price = 10.50;
                    working = true;
                    break;
                case "april":
                    price = 10.50;
                    working = true;
                    break;
                case "may":
                    price = 10.50;
                    working = true;
                    break;
                case "june":
                    price = 12.60;
                    working = true;
                    break;
                case "july":
                    price = 12.60;
                    working = true;
                    break;
                case "august":
                    price = 12.60;
                    working = true;
                    break;
            }
        }
        else if (dayTime == "night")
        {
            switch (month)
            {
                case "march":
                    price = 8.4;
                    working = true;
                    break;
                case "april":
                    price = 8.4;
                    working = true;
                    break;
                case "may":
                    price = 8.4;
                    working = true;
                    break;
                case "june":
                    price = 10.20;
                    working = true;
                    break;
                case "july":
                    price = 10.20;
                    working = true;
                    break;
                case "august":
                    price = 10.20;
                    working = true;
                    break;
            }
        }

        if (people >= 4)
        {
            price *= 0.9;
        }

        if (hours >= 5)
        {
            price *= 0.5;
        }

        double total = price * hours * people;

        if (working)
        {
            Console.WriteLine($"Price per person for one hour: {price:F2}");
            Console.WriteLine($"Total cost of the visit: {total:F2}");
        }
    }
}