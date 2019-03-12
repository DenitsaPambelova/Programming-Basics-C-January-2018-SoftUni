using System;

class MoneyPrize
{
    static void Main(string[] args)
    {
        int parts = int.Parse(Console.ReadLine());
        double pointPrize = double.Parse(Console.ReadLine());

        double prize = 0;

        for (int part = 1; part <= parts; part++)
        {
            int points = int.Parse(Console.ReadLine());

            if (part % 2 == 0)
            {
                points *= 2;
            }

            prize += points * pointPrize;
        }

        Console.WriteLine($"The project prize was {prize:F2} lv.");
    }
}