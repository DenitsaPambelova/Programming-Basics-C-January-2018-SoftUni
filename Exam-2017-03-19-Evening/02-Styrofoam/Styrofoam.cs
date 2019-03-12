using System;

class Styrofoam
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        double area = double.Parse(Console.ReadLine());
        int windows = int.Parse(Console.ReadLine());
        double packageSize = double.Parse(Console.ReadLine());
        double packagePrice = double.Parse(Console.ReadLine());

        double coverArea = (area - windows * 2.4) * 1.1;
        double packages = Math.Ceiling(coverArea / packageSize);
        double fullPrice = packages * packagePrice;

        if (budget >= fullPrice)
        {
            Console.WriteLine($"Spent: {fullPrice:F2}");
            Console.WriteLine($"Left: {budget - fullPrice:F2}");
        }
        else
        {
            Console.WriteLine($"Need more: {fullPrice - budget:F2}");
        }
    }
}