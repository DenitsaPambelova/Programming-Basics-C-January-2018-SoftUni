using System;

class Vacation
{
    static void Main(string[] args)
    {
        int adults = int.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());
        string transport = Console.ReadLine().ToLower();

        double travelMoney = 0;
        double sleepMoney = nights * 82.99;

        switch (transport)
        {
            case "train":
                travelMoney = adults * 24.99 + students * 14.99;

                if (adults + students >= 50)
                {
                    travelMoney *= 0.5;
                }

                break;
            case "bus":
                travelMoney = adults * 32.5 + students * 28.5;
                break;
            case "boat":
                travelMoney = adults * 42.99 + students * 39.99;
                break;
            case "airplane":
                travelMoney = adults * 70 + students * 50;
                break;
        }

        travelMoney *= 2;

        double allMoney = (sleepMoney + travelMoney) * 1.1;

        Console.WriteLine($"{allMoney:F2}");
    }
}