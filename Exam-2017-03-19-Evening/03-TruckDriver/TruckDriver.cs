using System;

namespace _03_TruckDriver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            double km = double.Parse(Console.ReadLine());

            double price = 1.45;

            switch (season)
            {
                case "spring":
                case "autumn":
                    if (km <= 5000)
                    {
                        price = 0.75;
                    }
                    else if (km <= 10000)
                    {
                        price = 0.95;
                    }

                    break;
                case "summer":
                    if (km <= 5000)
                    {
                        price = 0.90;
                    }
                    else if (km <= 10000)
                    {
                        price = 1.10;
                    }

                    break;
                case "winter":
                    if (km <= 5000)
                    {
                        price = 1.05;
                    }
                    else if (km <= 10000)
                    {
                        price = 1.25;
                    }

                    break;
            }

            double sum = 4 * km * price * 0.9;

            Console.WriteLine($"{sum:F2}");
        }
    }
}
