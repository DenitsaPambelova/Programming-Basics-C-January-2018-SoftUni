using System;

class IvanoviHoliday
{
    static void Main(string[] args)
    {
        int nights = int.Parse(Console.ReadLine());
        string destination = Console.ReadLine();
        string transport = Console.ReadLine();

        double finalPrice = 0;

        switch (destination)
        {
            case "Miami":
                if (nights < 11)
                {
                    finalPrice += (2 * nights * 24.99 + 3 * nights * 14.99);
                }
                else if (nights > 15)
                {
                    finalPrice += (2 * nights * 20.00 + 3 * nights * 10.00);
                }
                else
                {
                    finalPrice += (2 * nights * 22.99 + 3 * nights * 11.99);
                }

                break;
            case "Canary Islands":
                if (nights < 11)
                {
                    finalPrice += (2 * nights * 32.50 + 3 * nights * 28.50);
                }
                else if (nights > 15)
                {
                    finalPrice += (2 * nights * 28.00 + 3 * nights * 22.00);
                }
                else
                {
                    finalPrice += (2 * nights * 30.50 + 3 * nights * 25.60);
                }

                break;
            case "Philippines":
                if (nights < 11)
                {
                    finalPrice += (2 * nights * 42.99 + 3 * nights * 39.99);
                }
                else if (nights > 15)
                {
                    finalPrice += (2 * nights * 38.50 + 3 * nights * 32.40);
                }
                else
                {
                    finalPrice += (2 * nights * 41.00 + 3 * nights * 36.00);
                }

                break;
        }

        finalPrice += finalPrice * 0.25;

        switch (transport)
        {
            case "train":
                finalPrice += (2 * 22.30 + 3 * 12.50);
                break;
            case "bus":
                finalPrice += (2 * 45.00 + 3 * 37.00);
                break;
            case "airplane":
                finalPrice += (2 * 90.00 + 3 * 68.50);
                break;
        }

        Console.WriteLine($"{finalPrice:F3}");
    }
}