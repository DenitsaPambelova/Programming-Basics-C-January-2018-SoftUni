using System;

class JuiceDiet
{
    static void Main(string[] args)
    {
        int allRaspberries = int.Parse(Console.ReadLine());
        int allStrawberries = int.Parse(Console.ReadLine());
        int allCherries = int.Parse(Console.ReadLine());
        double all = double.Parse(Console.ReadLine());

        int cherries = 0;
        int strawberries = 0;
        int raspberries = 0;
        double totalJuice = 0;

        for (int i = 0; i <= allCherries; i++)
        {
            for (int j = 0; j <= allStrawberries; j++)
            {
                for (int k = 0; k <= allRaspberries; k++)
                {
                    double fruits = i * 15 + j * 7.5 + k * 4.5;

                    if (fruits <= all && fruits > totalJuice)
                    {
                        totalJuice = fruits;
                    }
                }
            }
        }

        for (int i = 0; i <= allCherries; i++)
        {
            for (int j = 0; j <= allStrawberries; j++)
            {
                for (int k = 0; k <= allRaspberries; k++)
                {
                    double fruits = i * 15 + j * 7.5 + k * 4.5;

                    if (fruits == totalJuice)
                    {
                        if (cherries < i)
                        {
                            cherries = i;
                        }
                    }
                }
            }
        }

        for (int j = 0; j <= allStrawberries; j++)
        {
            for (int k = 0; k <= allRaspberries; k++)
            {
                double fruits = cherries * 15 + j * 7.5 + k * 4.5;

                if (fruits == totalJuice)
                {
                    if (strawberries < j)
                    {
                        strawberries = j;
                    }
                }
            }
        }

        for (int k = 0; k <= allRaspberries; k++)
        {
            double fruits = cherries * 15 + strawberries * 7.5 + k * 4.5;

            if (fruits == totalJuice)
            {
                if (raspberries < k)
                {
                    raspberries = k;
                }
            }
        }

        Console.WriteLine($"{raspberries} Raspberries, {strawberries} Strawberries, {cherries} Cherries. Juice: {totalJuice} ml.");
    }
}