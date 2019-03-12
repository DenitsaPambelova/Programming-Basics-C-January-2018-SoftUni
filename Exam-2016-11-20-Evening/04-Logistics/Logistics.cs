using System;

class Logistics
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int bus = 0;
        int truck = 0;
        int train = 0;

        for (int i = 0; i < count; i++)
        {
            int weight = int.Parse(Console.ReadLine());

            if (weight <= 3)
            {
                bus += weight;
            }
            else if (weight <= 11)
            {
                truck += weight;
            }
            else
            {
                train += weight;
            }
        }

        double totalWeight = bus + truck + train;
        double average = (bus * 200 + truck * 175 + train * 120) / totalWeight;
        double busPercent = bus / totalWeight * 100;
        double truckPercent =truck / totalWeight * 100;
        double trainPercent =train / totalWeight * 100;

        Console.WriteLine($"{average:F2}");
        Console.WriteLine($"{busPercent:F2}%");
        Console.WriteLine($"{truckPercent:F2}%");
        Console.WriteLine($"{trainPercent:F2}%");
    }
}