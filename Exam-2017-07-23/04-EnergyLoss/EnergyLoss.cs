using System;

class EnergyLoss
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        int dancers = int.Parse(Console.ReadLine());

        int allEnergy = dancers * 100;
        double spentEnergy = 0;

        for (int day = 1; day <= days; day++)
        {
            int hours = int.Parse(Console.ReadLine());

            if (day % 2 == 1 && hours % 2 == 1)
            {
                spentEnergy += dancers * 30;
            }
            else if (day % 2 == 1 && hours % 2 == 0)
            {
                spentEnergy += dancers * 49;
            }
            else if (day % 2 == 0 && hours % 2 == 1)
            {
                spentEnergy += dancers * 65;
            }
            else
            {
                spentEnergy += dancers * 68;
            }
        }

        double dayEnergy = spentEnergy / days;
        double remainingEnergy = (allEnergy - dayEnergy) / dancers;
        string output = $"They are wasted! Energy left: {remainingEnergy:F2}";

        if (remainingEnergy >= dayEnergy / dancers)
        {
            output = $"They feel good! Energy left: {remainingEnergy:F2}";
        }

        Console.WriteLine(output);
    }
}